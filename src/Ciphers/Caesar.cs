using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using RGiesecke.DllExport;

namespace Ciphers
{
    public class Caesar
    {
        [DllExport("AddOne", CallingConvention = CallingConvention.Cdecl)]
        public static int AddOne(int source)
        {
            return source + 1;
        }

        [DllExport("CaesarCipher", CallingConvention = CallingConvention.Cdecl)]
        public static string Cipher(string plaintext)
        {
            var ciphertext = new StringBuilder();
            foreach(char c in plaintext)
            {
                if (c >= 'a' && c <= 'm')
                {
                    ciphertext.Append((char)(c + 13));
                }
                else if (c >= 'n' && c <= 'z')
                {
                    ciphertext.Append((char)(c - 13));
                }
                else if (c >= 'A' && c <= 'M')
                {
                    ciphertext.Append((char)(c + 13));
                }
                else if (c >= 'N' && c <= 'Z')
                {
                    ciphertext.Append((char)(c - 13));
                }
            }
            return ciphertext.ToString();
        }
    }
}
