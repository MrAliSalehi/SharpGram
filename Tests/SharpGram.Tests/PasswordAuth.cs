using System.Numerics;
using System.Text;
using FluentAssertions;
using SharpGram.Core.Models.Errors;
using SharpGram.Tl.Constructors.AccountPasswordNs;
using SharpGram.Tl.Constructors.InputCheckPasswordSRPNs;
using SharpGram.Tl.Constructors.PasswordKdfAlgoNs;
using SharpGram.Tl.Constructors.SecurePasswordKdfAlgoNs;

namespace SharpGram.Tests;

public class PasswordAuth
{
    [Test]
    public void SafePrime()
    {
        var safePrimes = new[] { 5, 7, 11, 23, 47, 59, 83, 107, 167, 179 };
        foreach (var p in safePrimes)
            Core.Cryptography.PasswordAuth.IsSafePrime(p).Should().Be(true);

        Core.Cryptography.PasswordAuth.IsSafePrime(2).Should().Be(false);
        Core.Cryptography.PasswordAuth.IsSafePrime(546).Should().Be(false);
        Core.Cryptography.PasswordAuth.IsSafePrime(BigInteger.Parse("123932942934234")).Should().Be(false);
        Core.Cryptography.PasswordAuth.IsSafePrime(BigInteger.Parse("45982394823849445645")).Should().Be(false);
        Core.Cryptography.PasswordAuth.IsSafePrime(BigInteger.Parse("234832472347123")).Should().Be(false);
    }
    [Test]
    public void GenerateSrp()
    {
        var pwd = new AccountPassword
        {
            SecureRandom = [12, 43],
            SrpB = [10],
            CurrentAlgo = new PasswordKdfAlgoSHA256SHA256PBKDF2HMACSHA512iter100000SHA256ModPow
            {
                Salt1 = [12],
                Salt2 = [24],
                G = 3,
                P = [23]
            },
            NewAlgo = new PasswordKdfAlgoUnknown(),
            NewSecureAlgo = new SecurePasswordKdfAlgoUnknown(),
            SrpId = 0
        };
        var srp = Core.Cryptography.PasswordAuth.GenerateSrp(pwd, "test"u8.ToArray());
        var s = (InputCheckPasswordSRP)srp.AsT0;


        var m1 = new byte[] { 114, 140, 58, 5, 82, 224, 12, 114, 246, 40, 158, 131, 184, 15, 97, 245, 54, 17, 146, 3, 148, 91, 22, 143, 49, 107, 78, 118, 52, 179, 113, 25, };
        var a = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 9, };

        s.SrpId.Should().Be(0);
        s.M1.Should().BeEquivalentTo(m1);
        s.A.Should().BeEquivalentTo(a);

        //something that is not safe prime and its invalid
        ((PasswordKdfAlgoSHA256SHA256PBKDF2HMACSHA512iter100000SHA256ModPow)pwd.CurrentAlgo).P = [123];
        var srp2 = Core.Cryptography.PasswordAuth.GenerateSrp(pwd, "test"u8.ToArray());
        srp2.TryPickT1(out var e, out _).Should().BeTrue();
        e.ErrorType.Should().Be(LoginErrorType.InvalidP);

        //invalid kdf
        pwd.CurrentAlgo = new PasswordKdfAlgoUnknown();
        var srp3 = Core.Cryptography.PasswordAuth.GenerateSrp(pwd, "test"u8.ToArray());
        srp3.TryPickT1(out var e2, out _).Should().BeTrue();
        e2.ErrorType.Should().Be(LoginErrorType.InvalidKdf);

        //invalid g

        for (var i = 1; i < 8; i++)
        {
            var r = Core.Cryptography.PasswordAuth.IsValidG(i, 0);
            if (i is 4)
                r.Should().BeTrue();
            else
                r.Should().BeFalse();
        }
    }

    //test data for these 2 functions were taken from grammers library.
    [Test]
    public void GenerateSrp2()
    {
        byte[] salt1 = [1];
        byte[] salt2 = [2];
        var g = 3;
        byte[] p =
        [
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 47
        ];
        byte[] gB = [5];
        byte[] a = [6];
        var pwd = new AccountPassword
        {
            NewAlgo = null!, NewSecureAlgo = null!,
            CurrentAlgo = new PasswordKdfAlgoSHA256SHA256PBKDF2HMACSHA512iter100000SHA256ModPow { Salt1 = salt1, Salt2 = salt2, P = p, G = g, },
            SecureRandom = a, SrpB = gB, SrpId = 0
        };

        var aResult = new byte[]
        {
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 24,
        };

        var m1Res = new byte[]
        {
            157, 131, 196, 103, 0, 184, 116, 232, 7, 196, 85, 231, 17, 36, 30, 222, 158, 234, 98,
            88, 59, 56, 71, 215, 183, 123, 122, 50, 19, 32, 54, 206,
        };
        var srp = Core.Cryptography.PasswordAuth.GenerateSrp(pwd, [7]);

        var srp2 = (InputCheckPasswordSRP)srp.AsT0;

        srp2.A.Should().BeEquivalentTo(aResult);
        srp2.M1.Should().BeEquivalentTo(m1Res);
    }
     [Test]
    public void GenerateSrp3()
    {
        byte[] salt1 = [  0x5f, 0x48, 0x3c, 0x38, 0xbd, 0x9, 0x86, 0xe7, 0xcd, 0xc9, 0x5a, 0xe1, 0x38, 0xef,
            0x4f, 0x49, 0xb9, 0x51, 0xc1, 0xf8, 0x1c, 0x71, 0x3f, 0xec, 0xde, 0xf3, 0xaf, 0x69,
            0x2c, 0xec, 0x4b, 0x47, 0x16, 0xac, 0x9b, 0x77, 0xa, 0x19, 0x5e, 0xbe,];
        byte[] salt2 = [  0xb6, 0x16, 0xfc, 0x6b, 0xbe, 0xdf, 0x51, 0x11, 0x19, 0xc5, 0xed, 0x34, 0x62, 0x95,
            0x27, 0xf1,];
        var g = 3;
        byte[] p =
        [
            0xc7, 0x1c, 0xae, 0xb9, 0xc6, 0xb1, 0xc9, 0x4, 0x8e, 0x6c, 0x52, 0x2f, 0x70, 0xf1,
            0x3f, 0x73, 0x98, 0xd, 0x40, 0x23, 0x8e, 0x3e, 0x21, 0xc1, 0x49, 0x34, 0xd0, 0x37,
            0x56, 0x3d, 0x93, 0xf, 0x48, 0x19, 0x8a, 0xa, 0xa7, 0xc1, 0x40, 0x58, 0x22, 0x94, 0x93,
            0xd2, 0x25, 0x30, 0xf4, 0xdb, 0xfa, 0x33, 0x6f, 0x6e, 0xa, 0xc9, 0x25, 0x13, 0x95,
            0x43, 0xae, 0xd4, 0x4c, 0xce, 0x7c, 0x37, 0x20, 0xfd, 0x51, 0xf6, 0x94, 0x58, 0x70,
            0x5a, 0xc6, 0x8c, 0xd4, 0xfe, 0x6b, 0x6b, 0x13, 0xab, 0xdc, 0x97, 0x46, 0x51, 0x29,
            0x69, 0x32, 0x84, 0x54, 0xf1, 0x8f, 0xaf, 0x8c, 0x59, 0x5f, 0x64, 0x24, 0x77, 0xfe,
            0x96, 0xbb, 0x2a, 0x94, 0x1d, 0x5b, 0xcd, 0x1d, 0x4a, 0xc8, 0xcc, 0x49, 0x88, 0x7, 0x8,
            0xfa, 0x9b, 0x37, 0x8e, 0x3c, 0x4f, 0x3a, 0x90, 0x60, 0xbe, 0xe6, 0x7c, 0xf9, 0xa4,
            0xa4, 0xa6, 0x95, 0x81, 0x10, 0x51, 0x90, 0x7e, 0x16, 0x27, 0x53, 0xb5, 0x6b, 0xf,
            0x6b, 0x41, 0xd, 0xba, 0x74, 0xd8, 0xa8, 0x4b, 0x2a, 0x14, 0xb3, 0x14, 0x4e, 0xe, 0xf1,
            0x28, 0x47, 0x54, 0xfd, 0x17, 0xed, 0x95, 0xd, 0x59, 0x65, 0xb4, 0xb9, 0xdd, 0x46,
            0x58, 0x2d, 0xb1, 0x17, 0x8d, 0x16, 0x9c, 0x6b, 0xc4, 0x65, 0xb0, 0xd6, 0xff, 0x9c,
            0xa3, 0x92, 0x8f, 0xef, 0x5b, 0x9a, 0xe4, 0xe4, 0x18, 0xfc, 0x15, 0xe8, 0x3e, 0xbe,
            0xa0, 0xf8, 0x7f, 0xa9, 0xff, 0x5e, 0xed, 0x70, 0x5, 0xd, 0xed, 0x28, 0x49, 0xf4, 0x7b,
            0xf9, 0x59, 0xd9, 0x56, 0x85, 0xc, 0xe9, 0x29, 0x85, 0x1f, 0xd, 0x81, 0x15, 0xf6, 0x35,
            0xb1, 0x5, 0xee, 0x2e, 0x4e, 0x15, 0xd0, 0x4b, 0x24, 0x54, 0xbf, 0x6f, 0x4f, 0xad,
            0xf0, 0x34, 0xb1, 0x4, 0x3, 0x11, 0x9c, 0xd8, 0xe3, 0xb9, 0x2f, 0xcc, 0x5b,
        ];
        byte[] gB = [ 0x93, 0xf7, 0xe, 0xbd, 0x50, 0xf6, 0x42, 0x6a, 0xca, 0x25, 0x68, 0x76, 0x95, 0x99,
            0xf9, 0x1f, 0x24, 0xd0, 0x12, 0x84, 0xcc, 0x51, 0xa4, 0x49, 0xe6, 0x2d, 0xcc, 0x15,
            0x27, 0xdf, 0xe5, 0x1, 0x26, 0xb2, 0xaa, 0x44, 0x23, 0x8e, 0x4f, 0xb2, 0x33, 0x14,
            0x19, 0xed, 0x4a, 0xeb, 0xf1, 0xa0, 0xae, 0x15, 0xe0, 0x3a, 0xbd, 0x18, 0xbf, 0xc5,
            0x2c, 0xa6, 0xba, 0xec, 0x56, 0x4c, 0x13, 0xb5, 0xa1, 0xd2, 0xe3, 0x57, 0x79, 0x98,
            0x97, 0x75, 0x7b, 0xb7, 0x36, 0xfd, 0xc2, 0xce, 0xb1, 0xb5, 0x6a, 0xac, 0xf1, 0x9a,
            0xb3, 0x54, 0x8d, 0x6d, 0x92, 0x2a, 0x52, 0x2f, 0xb, 0x51, 0xf4, 0x1, 0x24, 0xc3, 0xbc,
            0x99, 0x36, 0xaf, 0xf3, 0xe1, 0xdc, 0xfb, 0xea, 0x39, 0xac, 0x9a, 0xd2, 0xad, 0xdc,
            0x6a, 0xf0, 0xad, 0x30, 0x78, 0x32, 0x78, 0xbb, 0xb8, 0x4c, 0xab, 0xe, 0xd8, 0x46,
            0x4b, 0xf, 0xfe, 0xb2, 0xb0, 0xc9, 0x3a, 0x39, 0xa5, 0xd9, 0x7d, 0xba, 0x1, 0x5, 0x67,
            0x2c, 0xa5, 0x47, 0x53, 0x73, 0xd8, 0xd2, 0x3e, 0x54, 0xa6, 0xac, 0x9b, 0xed, 0x95,
            0x19, 0xe8, 0xbe, 0xf4, 0xf0, 0x7, 0x19, 0xf5, 0xad, 0x56, 0x15, 0x1b, 0xe5, 0x53,
            0x76, 0x48, 0xdf, 0x2f, 0x8e, 0x3e, 0x72, 0x65, 0xcb, 0x57, 0xfb, 0x94, 0xa0, 0x54,
            0xce, 0x2a, 0x82, 0xb8, 0xcc, 0x66, 0x4a, 0xd0, 0x60, 0xe0, 0xd6, 0xc6, 0xdf, 0x18,
            0x79, 0x34, 0x54, 0x40, 0xeb, 0x97, 0x7f, 0xa0, 0xf2, 0xd3, 0x6f, 0x31, 0xa2, 0x53,
            0xd8, 0x91, 0x77, 0x32, 0xf1, 0x33, 0xd4, 0x0, 0x33, 0xa3, 0x4b, 0x61, 0x52, 0x96,
            0x9b, 0x60, 0xd, 0x59, 0xcd, 0xab, 0xfe, 0xa2, 0xab, 0x23, 0x93, 0xad, 0x65, 0x9e,
            0x56, 0xd6, 0x6e, 0x13, 0x60, 0x5b, 0x1f, 0x61, 0xe4, 0x8e, 0x3c, 0xd6, 0x5c, 0xf,
            0x58, 0xac,];
        byte[] a = [ 0xbf, 0x31, 0x57, 0x4f, 0x34, 0xfc, 0xe1, 0xe5, 0x38, 0x91, 0xc5, 0x9b, 0x7f, 0x62,
            0x46, 0x8a, 0xc, 0xa6, 0x82, 0xda, 0x85, 0x85, 0xdf, 0x8d, 0xe0, 0xa1, 0x88, 0x73,
            0x35, 0x97, 0x55, 0xfb, 0xb1, 0x81, 0x88, 0x78, 0xa9, 0xee, 0x91, 0x9b, 0xb1, 0xe9,
            0x4d, 0x20, 0xc5, 0xf0, 0x60, 0x7e, 0x2, 0xa3, 0x31, 0x76, 0x19, 0x9b, 0xf3, 0x22, 0x2,
            0x56, 0xc9, 0xea, 0x1a, 0x69, 0xf3, 0x95, 0xa5, 0x15, 0xd2, 0x5, 0x39, 0xd8, 0x8c,
            0xda, 0x75, 0xa, 0x52, 0x52, 0xfb, 0x86, 0x4f, 0x57, 0x3f, 0x2b, 0x3, 0x2f, 0x3b, 0x46,
            0x7d, 0x8, 0xb3, 0x4f, 0xd9, 0xc8, 0x9d, 0x1c, 0x5d, 0x6, 0x27, 0x8e, 0x11, 0x3e, 0x51,
            0xd4, 0xe8, 0x93, 0xc1, 0xc0, 0x27, 0x45, 0x5a, 0xf4, 0x65, 0x3f, 0x9, 0x66, 0x7, 0xa4,
            0x15, 0x6d, 0x94, 0xfb, 0x8e, 0x1d, 0xc7, 0xce, 0xe5, 0xbf, 0xe3, 0x28, 0x50, 0x98,
            0x2f, 0x94, 0x1a, 0xe4, 0x41, 0x4e, 0x83, 0xbf, 0x22, 0xdf, 0x56, 0x27, 0xb, 0x43,
            0xb7, 0xcc, 0xc4, 0x4c, 0x26, 0xd4, 0x8, 0x86, 0x46, 0x4d, 0xa8, 0xe3, 0x44, 0xa8,
            0x54, 0x7, 0x95, 0xb8, 0xf6, 0x9b, 0x8f, 0x50, 0x85, 0x52, 0xa7, 0x23, 0xcd, 0x69,
            0x31, 0xe1, 0xd6, 0x92, 0x4, 0xe8, 0xe9, 0xdc, 0x5, 0x6f, 0xa, 0x2a, 0x10, 0xa0, 0xd7,
            0x95, 0x1e, 0x35, 0x5f, 0x3e, 0xde, 0xf5, 0xa5, 0xe1, 0x8a, 0x90, 0x91, 0x29, 0x5a,
            0x51, 0xeb, 0x9d, 0xb1, 0xb, 0x8b, 0xd, 0x30, 0x48, 0x9c, 0x8d, 0x29, 0xbc, 0xc, 0xd8,
            0x6e, 0x97, 0x78, 0x1f, 0x5e, 0x30, 0xc5, 0xb6, 0xbf, 0xe7, 0xca, 0xf4, 0xaa, 0xe8,
            0x1b, 0x28, 0x2e, 0x65, 0x3a, 0xc4, 0x8a, 0xa1, 0xa8, 0xfd, 0xe7, 0x89, 0x72, 0x2b,
            0xc0, 0x4f, 0x43, 0x20, 0xcd, 0x9f, 0x86, 0x84, 0x9f, 0xe0, 0x5c, 0xa4,];
        var pwd = new AccountPassword
        {
            NewAlgo = null!, NewSecureAlgo = null!,
            CurrentAlgo = new PasswordKdfAlgoSHA256SHA256PBKDF2HMACSHA512iter100000SHA256ModPow { Salt1 = salt1, Salt2 = salt2, P = p, G = g, },
            SecureRandom = a, SrpB = gB, SrpId = 0
        };

        var aResult = new byte[]
        {
            15, 161, 43, 198, 85, 177, 24, 122, 40, 41, 106, 105, 174, 86, 93, 104, 39, 130, 224,
            206, 176, 90, 8, 156, 12, 65, 193, 220, 233, 131, 220, 127, 74, 83, 67, 78, 167, 142,
            6, 93, 158, 28, 182, 14, 66, 123, 68, 104, 164, 120, 6, 9, 254, 186, 47, 85, 101, 78,
            226, 239, 224, 174, 183, 46, 218, 253, 226, 101, 46, 38, 237, 91, 77, 75, 170, 217,
            210, 163, 129, 128, 106, 246, 52, 22, 191, 98, 99, 223, 69, 164, 61, 133, 190, 84, 1,
            188, 34, 62, 191, 172, 9, 66, 28, 173, 221, 126, 38, 11, 214, 184, 101, 66, 19, 60, 4,
            141, 108, 213, 75, 56, 216, 226, 204, 223, 107, 85, 14, 135, 91, 19, 83, 164, 172, 254,
            50, 146, 255, 181, 106, 15, 88, 178, 163, 144, 39, 201, 191, 221, 145, 253, 76, 83, 29,
            35, 199, 125, 110, 143, 125, 88, 62, 174, 234, 49, 109, 237, 222, 214, 153, 53, 41,
            108, 231, 234, 52, 233, 190, 110, 242, 251, 216, 41, 234, 196, 201, 189, 100, 109, 193,
            86, 62, 71, 247, 123, 145, 67, 28, 160, 2, 207, 121, 252, 20, 157, 150, 130, 114, 131,
            92, 21, 202, 28, 107, 44, 94, 3, 113, 42, 46, 27, 93, 82, 245, 228, 250, 161, 193, 108,
            177, 119, 250, 253, 150, 166, 170, 91, 75, 63, 76, 100, 153, 21, 100, 75, 99, 133, 92,
            251, 56, 86, 31, 241, 127, 237, 251, 138,
        };

        var m1Res = new byte[]
        {
            77, 122, 244, 18, 197, 162, 231, 177, 84, 103, 55, 107, 209, 24, 184, 83, 96, 78, 104,
            123, 49, 245, 28, 73, 128, 196, 215, 193, 135, 102, 19, 227,
        };
        var srp = Core.Cryptography.PasswordAuth.GenerateSrp(pwd, [50, 51, 52, 53, 54, 55]);

        var srp2 = (InputCheckPasswordSRP)srp.AsT0;

        srp2.A.Should().BeEquivalentTo(aResult);
        srp2.M1.Should().BeEquivalentTo(m1Res);
    }
}