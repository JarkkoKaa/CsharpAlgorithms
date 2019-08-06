using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpAlgorithms.Encryptions.CaesarCipher
{
    class CCEncryption
    {
        /// <summary>
        /// Plaintext with key to transform text
        /// </summary>
        /// <param name="plaintext"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public string Encryption(string plaintext, int key)
        {
            string encrypted = String.Empty;

            for (int i = 0; i < plaintext.Length; i++)
            {
                // if whitespace
                if (plaintext[i].Equals(' '))
                    encrypted += plaintext[i];
                else
                {
  
                }
            }
            return encrypted;
        }
    }
}
