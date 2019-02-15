#if !NETSTANDARD1_3

using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BinaryTools.Security.Cryptography
{
    public class LM
    {

        public byte[] ComputeHalf(byte[] half)
        {

            if (half.Length == 0)
                return new byte[] { 0xAA, 0xD3, 0xB4, 0x35, 0xB5, 0x14, 0x04, 0xEE };
            else if (half.Length > 7)
                throw new NotSupportedException("Password halves greater than 7 " +
                "characters are not supported");

            Array.Resize(ref half, 7);

            StringBuilder binaryString = new StringBuilder();

            foreach (char c in half)
            {
                string s = Convert.ToString(c, 2);

                int padLen = 8 - s.Length;

                binaryString.Append(new string('0', padLen) + s);
            }

            for (int y = 8; y > 0; y--)
                binaryString.Insert(y * 7, '0');

            string binary = binaryString.ToString();

            byte[] key = new byte[8];

            for (int y = 0; y < 8; y++)
                key[y] = Convert.ToByte(binary.Substring(y * 8, 8), 2);

            DESCryptoServiceProvider des = new DESCryptoServiceProvider
            {
                Key = key,
                IV = new byte[8]
            };

            using (MemoryStream stream = new MemoryStream())
            {
                using (CryptoStream cryptStream = new CryptoStream(stream,
                des.CreateEncryptor(), CryptoStreamMode.Write))
                using (StreamWriter writer = new StreamWriter(cryptStream))
                    writer.Write("KGS!@#$%");

                byte[] b = stream.ToArray();

                Array.Resize(ref b, 8);

                return b;
            }
        }

        public byte[] Compute(string password)
        {
            if (password.Length > 14)
                throw new NotSupportedException("Passwords greater than 14 " +
                "characters are not supported");

            byte[] passBytes = Encoding.ASCII.GetBytes(password.ToUpper());

            byte[][] passHalves = new byte[2][];

            if (passBytes.Length > 7)
            {
                int len = passBytes.Length - 7;

                passHalves[0] = new byte[7];
                passHalves[1] = new byte[len];

                Array.Copy(passBytes, passHalves[0], 7);
                Array.Copy(passBytes, 7, passHalves[1], 0, len);
            }
            else
            {
                passHalves[0] = passBytes;
                passHalves[1] = new byte[0];
            }

            for (int x = 0; x < 2; x++)
                passHalves[x] = ComputeHalf(passHalves[x]);

            byte[] hash = new byte[16];

            Array.Copy(passHalves[0], hash, 8);
            Array.Copy(passHalves[1], 0, hash, 8, 8);

            return hash;
        }

        public string ComputeHash(string input)
        {
            byte[] output = Compute(input);
            return output.Aggregate(new StringBuilder(output.Length * 2), (sb, b) => sb.AppendFormat("{0:X2}", b)).ToString();
        }
    }

}

#endif
