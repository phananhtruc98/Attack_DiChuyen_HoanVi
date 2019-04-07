using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Attack_ATMB.MyLibrary
{
    public class FileHelper
    {
        public static string ReadFile(string path)
        {
            return File.ReadAllText(path);
        }

        public static void WriteFile(string path, string[] lines)
        {
            File.WriteAllLines(path, lines);
        }
    }


}
