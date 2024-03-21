using FluentAssertions;
using SharpGram.Core.Cryptography;

namespace SharpGram.Tests;

public class Rsa
{
    private const string N = "25342889448840415564971689590713473206898847759084779052582026594546022463853940585885215951168491965708222649399180603818074200620463776135424884632162512403163793083921641631564740959529419359595852941166848940585952337613333022396096584117954892216031229237302943701877588456738335398602461675225081791820393153757504952636234951323237820036543581047826906120927972487366805292115792231423684261262330394324750785450942589751755390156647751460719351439969059949569615302809050721500330239005077889855323917509948255722081644689442127297605422579707142646660768825302832201908302295573257427896031830742328565032949";
    private const string E = "65537";

    [Test]
    public void EncryptRsaWithPublicKey()
    {
        var data = ConvertHexStringToByteArray("955ff5a9081a8e635f5743de9b00000004453dc27100000004622f1fcb000000f7a81627bbf511fa4afef71e94a0937474586c1add9198dda81a5df8393871c8293623c5fb968894af1be7dfe9c7be813f9307789242fd0cb0c16a5cb39a8d3e");
        var random = ConvertHexStringToByteArray("12270000635593b03fee033d0672f9afddf9124de9e77df6251806cba93482e4c9e6e06e7d44e4c4baae821aff91af44789689faaee9bdfc7b2df8c08709afe57396c4638ceaa0dc30114f82447e81d3b53edc423b32660c43a5b8ad057b64500000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000007dada0920c4973913229e0f881aec7b9db0c392d34f52fb0995ea493ecb4c09daaf68fe9554ec7a59c03e4035952b220b47a8d06aad71134110d8c44948901f8");
        var encrypted = ConvertHexStringToByteArray("c6d211349fc10cda6983276250b09f4be9b39f533b5d314b732b51a6dd72234dab4224209992c894e0e4c9f30249f1dbbd1630a27b98f2f92a53c00baabbd46f380bd35f417e5ec2edb43f7644b5c81af011d736eb369265e848b553ae5e6350dd5695efc72bde0e35f3c3fc827b91eb97cf1efdbff12269b9c33f81645adebc89ed167edc19d285237a754bf629aa358ed08498863b2aec8b7139001627bbe8bdef239474a5a43e664d278f39e72d694a206d7b838fd40868a71c4bfbffa38b7679faa502b7795cbe5ae1bd05ca7eb01ff5b05107265fd39bd5b4e19d392b735a3b0b5b21473062981bff86ff9084a7b594775e3127c05fd454e19f794a4ab4");
        var key = new RsaEncryption(N, E);
        var result = key.Encrypt(data, random);

        result.Should().BeEquivalentTo(encrypted);
    }

    [Test]
    public void RsaWithPubKey()
    {
        var rsa = new RsaEncryption("""
                                    -----BEGIN RSA PUBLIC KEY-----
                                    MIIBCgKCAQEA6LszBcC1LGzyr992NzE0ieY+BSaOW622Aa9Bd4ZHLl+TuFQ4lo4g
                                    5nKaMBwK/BIb9xUfg0Q29/2mgIR6Zr9krM7HjuIcCzFvDtr+L0GQjae9H0pRB2OO
                                    62cECs5HKhT5DZ98K33vmWiLowc621dQuwKWSQKjWf50XYFw42h21P2KXUGyp2y/
                                    +aEyZ+uVgLLQbRA1dEjSDZ2iGRy12Mk5gpYc397aYp438fsJoHIgJ2lgMv5h7WY9
                                    t6N/byY9Nw9p21Og3AoXSL2q/2IJ1WRUhebgAdGVMlV1fkuOQoEzR7EdpqtQD9Cs
                                    5+bfo3Nhmcyvk5ftB0WkJ9z6bNZ7yxrP8wIDAQAB
                                    -----END RSA PUBLIC KEY-----
                                    """);
        rsa.N.ToString().Should().BeEquivalentTo("29379598170669337022986177149456128565388431120058863768162556424047512191330847455146576344487764408661701890505066208632169112269581063774293102577308490531282748465986139880977280302242772832972539403531316010870401287642763009136156734339538042419388722777357134487746169093539093850251243897188928735903389451772730245253062963384108812842079887538976360465290946139638691491496062099570836476454855996319192747663615955633778034897140982517446405334423701359108810182097749467210509584293428076654573384828809574217079944388301239431309115013843331317877374435868468779972014486325557807783825502498215169806323");
        rsa.E.ToString().Should().BeEquivalentTo("65537");
        Console.WriteLine();
    }

    [Test]
    public void Encrypt1() => new Ige(KeyTest1, IvTest1).Encrypt(PlainText1).Should().BeEquivalentTo(CipherText1);

    [Test]
    public void Encrypt2() => new Ige(KeyTest2, IvTest2).Encrypt(PlainText2).Should().BeEquivalentTo(CipherText2);

    [Test]
    public void Decrypt1() => new Ige(KeyTest1, IvTest1).Decrypt(CipherText1).Should().BeEquivalentTo(PlainText1);

    [Test]
    public void Decrypt2() => new Ige(KeyTest2, IvTest2).Decrypt(CipherText2).Should().BeEquivalentTo(PlainText2);

    private static readonly byte[] KeyTest1 = [0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F];
    private static readonly byte[] IvTest1 = [0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17, 0x18, 0x19, 0x1A, 0x1B, 0x1C, 0x1D, 0x1E, 0x1F];
    private static readonly byte[] PlainText1 = new byte[32];
    private static readonly byte[] CipherText1 = [0x1A, 0x85, 0x19, 0xA6, 0x55, 0x7B, 0xE6, 0x52, 0xE9, 0xDA, 0x8E, 0x43, 0xDA, 0x4E, 0xF4, 0x45, 0x3C, 0xF4, 0x56, 0xB4, 0xCA, 0x48, 0x8A, 0xA3, 0x83, 0xC7, 0x9C, 0x98, 0xB3, 0x47, 0x97, 0xCB];
    private static readonly byte[] KeyTest2 = [0x54, 0x68, 0x69, 0x73, 0x20, 0x69, 0x73, 0x20, 0x61, 0x6E, 0x20, 0x69, 0x6D, 0x70, 0x6C, 0x65];
    private static readonly byte[] IvTest2 = [0x6D, 0x65, 0x6E, 0x74, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x20, 0x6F, 0x66, 0x20, 0x49, 0x47, 0x45, 0x20, 0x6D, 0x6F, 0x64, 0x65, 0x20, 0x66, 0x6F, 0x72, 0x20, 0x4F, 0x70, 0x65, 0x6E, 0x53, 0x53];
    private static readonly byte[] PlainText2 = [0x99, 0x70, 0x64, 0x87, 0xA1, 0xCD, 0xE6, 0x13, 0xBC, 0x6D, 0xE0, 0xB6, 0xF2, 0x4B, 0x1C, 0x7A, 0xA4, 0x48, 0xC8, 0xB9, 0xC3, 0x40, 0x3E, 0x34, 0x67, 0xA8, 0xCA, 0xD8, 0x93, 0x40, 0xF5, 0x3B];
    private static readonly byte[] CipherText2 = [0x4C, 0x2E, 0x20, 0x4C, 0x65, 0x74, 0x27, 0x73, 0x20, 0x68, 0x6F, 0x70, 0x65, 0x20, 0x42, 0x65, 0x6E, 0x20, 0x67, 0x6F, 0x74, 0x20, 0x69, 0x74, 0x20, 0x72, 0x69, 0x67, 0x68, 0x74, 0x21, 0x0A];
    private static byte[] ConvertHexStringToByteArray(string hexString)
    {
        if (hexString.Length % 2 != 0) throw new ArgumentException("Hex string must have an even number of characters.");

        var byteArray = new byte[hexString.Length / 2];

        for (var i = 0; i < byteArray.Length; i++)
            byteArray[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);

        return byteArray;
    }
}