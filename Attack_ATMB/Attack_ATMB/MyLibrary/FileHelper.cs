﻿using System;
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

        public static void WriteFile(string path, string encryptName, string z, string k, string s)
        {
            File.WriteAllText(path, encryptName + Environment.NewLine + z + Environment.NewLine + k + Environment.NewLine + s);
        }
        public static void WriteFile(string path, string encryptName, string z, string s)
        {
            File.WriteAllText(path, encryptName + Environment.NewLine + z + Environment.NewLine + s);
        }
    }


}
