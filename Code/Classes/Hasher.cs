using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows;

namespace Project_C14.Code.Classes;

public class Hasher
{
    public static string HashSha512(string StringToHash)
    {
        byte[] bytePassword = Encoding.UTF8.GetBytes(StringToHash);

        SHA512 mSHA = new SHA512Managed();
        return BitConverter.ToString(mSHA.ComputeHash(bytePassword)).Replace("-", string.Empty);
    }
}