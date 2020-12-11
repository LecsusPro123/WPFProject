using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFProjectFinal
{
    public class VigenereCipher
    {
        private static List<char> alpha = new List<char> { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м',
                                    'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы',
                                    'ь', 'э', 'ю', 'я'};

        public static string Encipher(string startStr, string key)
        {
            if (string.IsNullOrEmpty(startStr))
            {
                throw new Exception("Введите исходный текст");
            }

            string result = "";
            char[] keychars = key.ToCharArray().Select(it => char.ToLower(it)).ToArray();

            if (keychars.Any(item => !alpha.Contains(item)) || string.IsNullOrEmpty(key))
            {
                throw new Exception("Неправильно ввели ключ");
            }

            int index = 0;

            foreach (var item in startStr)
            {
                char current = char.ToLower(item);
                if (alpha.Contains(current))
                {
                    if (char.IsUpper(item))
                    {
                        result += char.ToUpper(alpha[(alpha.IndexOf(current) + alpha.IndexOf(keychars[index++])) % 33]);
                    }
                    else
                    {
                        result += alpha[(alpha.IndexOf(current) + alpha.IndexOf(keychars[index++])) % 33];
                    }

                    if (index == keychars.Length) { index = 0; }
                }
                else
                {
                    result += item;
                }
            }
            return result;
        }

        public static string Decipher(string startStr, string key)
        {
            if (string.IsNullOrEmpty(startStr))
            {
                throw new Exception("Введите исходный текст");
            }

            string result = "";
            char[] keychars = key.ToCharArray().Select(it => char.ToLower(it)).ToArray();

            if (keychars.Any(item => !alpha.Contains(item)) || string.IsNullOrEmpty(key))
            {
                throw new Exception("Неправильно ввели ключ");
            }

            int index = 0;

            foreach (var item in startStr)
            {
                char current = char.ToLower(item);
                if (alpha.Contains(current))
                {
                    if (char.IsUpper(item))
                    {
                        result += char.ToUpper(alpha[(alpha.IndexOf(current) + 33 - alpha.IndexOf(keychars[index++])) % 33]);
                    }
                    else
                    {
                        result += alpha[(alpha.IndexOf(current) + 33 - alpha.IndexOf(keychars[index++])) % 33];
                    }

                    if (index == keychars.Length) { index = 0; }
                }
                else
                {
                    result += item;
                }
            }
            return result;
        }
    }
}
