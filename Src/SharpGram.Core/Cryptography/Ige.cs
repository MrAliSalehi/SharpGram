using System.Security.Cryptography;

namespace SharpGram.Core.Cryptography;

// copied and modified under Apache License 2.

/// <summary>
/// this class along with its unit tests was taken from <a href="https://github.com/mIwr/AesIge">AesIge Package</a> thanks to its Author.
/// the only reason it wasn't added as a nuget package was that it needed some modifications, so it was copied manually.
/// </summary>
public sealed class Ige
{
    private readonly Aes _aes;

    public byte[] Iv { get; set; }

    public byte[] Key { get; set; } = null!;
    public Ige(byte[]? key = null, byte[]? iv = null)
    {
        _aes = Aes.Create();
        _aes.Mode = CipherMode.ECB;
        _aes.Padding = PaddingMode.None;
        _aes.KeySize = 256;
        if (key is not null)
            Key = key;
        Iv = iv ?? RandomNumberGenerator.GetBytes(32);
    }
    public static Ige From(AuthKey authKey, byte[] msgKey, bool isResponse)
    {
        var i = isResponse ? 8 : 0;
        var sha1 = SHA256.HashData(msgKey.Concat(authKey.AuthKeyData[i..(36 + i)]).ToArray());
        var sha2 = SHA256.HashData(authKey.AuthKeyData[(40 + i )..(76 + i)].Concat(msgKey).ToArray());

        var key = sha1[..8].Concat(sha2[8..24]).Concat(sha1[24..32]).ToArray();
        var iv = sha2[..8].Concat(sha1[8..24]).Concat(sha2[24..32]).ToArray();
        return new Ige(key, iv);
    }
    public byte[] Encrypt(byte[] plainBytes) => CipherProcess(plainBytes, encryptMode: true);

    public IEnumerable<byte> Decrypt(byte[] cipherBytes) => CipherProcess(cipherBytes, encryptMode: false);

    private byte[] CipherProcess(byte[] inputBytes, bool encryptMode)
    {
        ArgumentOutOfRangeException.ThrowIfNotEqual(inputBytes.Length % (_aes.BlockSize / 8), 0);

        var blocksCount = inputBytes.Length / (_aes.BlockSize / 8);
        var outputBytes = CreateBlocks(blocksCount);

        var cryptoTransformer = encryptMode ? _aes.CreateEncryptor(Key, null) : _aes.CreateDecryptor(Key, null);

        var iv1 = ExtractBlock(Iv, encryptMode ? 0 : 1);
        var iv2 = ExtractBlock(Iv, encryptMode ? 1 : 0);

        var outputBlock = CreateBlock();

        for (var i = 0; i < blocksCount; i++)
        {
            var inputBlock = ExtractBlock(inputBytes, i);

            XorBlocks(inputBlock, iv1, outputBlock);
            cryptoTransformer.TransformBlock(outputBlock, inputOffset: 0, inputCount: outputBlock.Length, outputBlock, outputOffset: 0);
            XorBlocks(outputBlock, iv2, outputBlock);

            CopyBlock(outputBlock, outputBytes, i);

            iv1 = outputBlock;
            iv2 = inputBlock;
        }

        return outputBytes;
    }

    private byte[] ExtractBlock(byte[] bytes, int blockPosition)
    {
        var blockSize = _aes.BlockSize / 8;
        var blockBytes = new byte[blockSize];
        Array.Copy(bytes, sourceIndex: blockPosition * blockSize, blockBytes, destinationIndex: 0, length: blockBytes.Length);
        return blockBytes;
    }

    private void CopyBlock(byte[] block, byte[] resultBytes, int blockPosition)
    {
        var blockSize = _aes.BlockSize / 8;
        Array.Copy(block, sourceIndex: 0, resultBytes, blockPosition * blockSize, blockSize);
    }

    private byte[] CreateBlock() => CreateBlocks(blocksCount: 1);

    private byte[] CreateBlocks(int blocksCount) => new byte[_aes.BlockSize / 8 * blocksCount];

    private void XorBlocks(IReadOnlyList<byte> block1, IReadOnlyList<byte> block2, IList<byte> resultBlock)
    {
        var blockSize = _aes.BlockSize / 8;
        for (var i = 0; i < blockSize; i++)
            resultBlock[i] = (byte)(block1[i] ^ block2[i]);
    }
}