using ClassLib.Modul;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerialOBJ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PC> pclist = new List<PC>();
            pclist.Add(new PC("pentium", Guid.NewGuid().ToString(), "ASUS", "Strix") { id=1});
            pclist.Add(new PC("core i3", Guid.NewGuid().ToString(), "INNO3D", "Edition") { id = 2 });
            pclist.Add(new PC("core i5", Guid.NewGuid().ToString(), "GIGABYTE", "GAMING") { id = 3 });
            pclist.Add(new PC("core i7", Guid.NewGuid().ToString(), "PALIT", "FORSE") { id = 4 });

            BinaryFormatter bf = new BinaryFormatter();

            using(FileStream fs=new FileStream("listSerial.txt", FileMode.OpenOrCreate))
            {
                bf.Serialize(fs, pclist);
                Console.WriteLine("Obj Serialize");
            }
        }
    }
}
