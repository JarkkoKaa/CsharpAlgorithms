using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsharpAlgorithms.Encryptions
{
    /// <summary>
    /// Encrypt: key for shifts
    /// Decrypt: 26 - key
    /// </summary>
    class CCEncryption
    {
        /// <summary>
        /// Plaintext with a key to transform text, encrypts text only excluding whitespaces, symbols and numbers.
        /// Encryption function can be used to encrypt and decrypt
        /// </summary>
        /// <param name="plaintext"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public string Encryption(string plaintext, int key)
        {
            string encrypted = String.Empty;

            for (int i = 0; i < plaintext.Length; i++)
            {
                // exclude whitespaces and non letter characters
                if (plaintext[i].Equals(' ') || !Char.IsLetter(plaintext[i]))
                    encrypted += plaintext[i];
                else
                {
                    int charToDecimal = 0;
                    /* Convert to Mathematical form: (x + n) mod 26
                    * Key is 3, Position of A in ASCII is 65: 65 + 3 = 68
                    * 68 - 65 = 3, 3 mod 26 = 3 so 3 + 65 = 68, result is D in ASCII */
                    if (Char.IsUpper(plaintext[i]))
                        charToDecimal = (plaintext[i] + key - 65) % 26 + 65;
                    if (Char.IsLower(plaintext[i]))
                        charToDecimal = (plaintext[i] + key - 97) % 26 + 97;
                    encrypted += (char)charToDecimal;
                }
            }
            return encrypted;
        }
    }
}
