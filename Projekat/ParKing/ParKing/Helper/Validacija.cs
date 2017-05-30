using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;

namespace ParKing.Helper
{
    public class Validacija
    {
        public static String createMD5(string input)
        {
            var algorithm = HashAlgorithmProvider.OpenAlgorithm(HashAlgorithmNames.Md5);
            IBuffer buffer = CryptographicBuffer.ConvertStringToBinary(input, BinaryStringEncoding.Utf8);
            var hashed = algorithm.HashData(buffer);
            var output = CryptographicBuffer.EncodeToHexString(hashed);

            return output;
        }
    }
}
