using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Attack_ATMB.MyLibrary
{
    public class Ceasar
    {
        //private static string z = "'aáàạảãăắằặẳẵâấầậẩẫbcdđeéẹẻẽêếềệểễfghiíìịỉĩjklmnoóòọỏõôốồộổỗơớờợởỡpqrstuúùụủũưứừựửữvwxyýỳỵỷỹAÁÀẠẢÃĂẮẰẶẲẴÂẤẦẬẨẪBCDĐEÉẸẺẼÊẾỀỆỂỄFGHIÍÌỊỈĨJKLMNOÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠPQRSTUÚÙỤỦŨƯỨỪỰỬỮVWXYÝỲỴỶỸ0123456789`~!@#$%^&*()\'";
        private static Regex regex = new Regex(@"\s");



        public static string Encipher(string input, int key,string z)
        {
            MatchCollection spaceChars = regex.Matches(input);
            var matches = regex.Matches(input)
                 .OfType<Match>().Select(m => m.Value).Distinct();

            string output = string.Empty;

            foreach (char ch in input)
            {

                if (matches.Contains(ch + "")) output += ch;
                else
                {
                    output += Cipher(ch, key,z);
                }

            }

            return output;
        }

        public static string Decipher(string input, int key,string z)
        {
            return Encipher(input, -key,z);
        }
        public static char Cipher(char ch, int key,string z)
        {
            if (z.IndexOf(ch) < 0) return ch;
            int i = (z.IndexOf(ch) + key) < 0 ? (z.Length + z.IndexOf(ch) + key) % z.Length : (z.IndexOf(ch) + key) % z.Length;
            return (char)z[i];
        }
    }
}
