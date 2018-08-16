using ClassLib.Modul;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DeserializConsolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryFormatter bf = new BinaryFormatter();

            using (FileStream fs = new FileStream(@"C:\Users\Клюкинк\Documents\Visual Studio 2015\Projects\ClassLib\SerialOBJ\bin\Debug\listSerial.txt", FileMode.OpenOrCreate))
            {              
                var t=(List<PC>)bf.Deserialize(fs);
                Console.WriteLine("Obj Deserialize");
                foreach (PC item in t)
                {
                    Console.WriteLine("Mark: :"+item.Mark);
                    Console.WriteLine("Model:" + item.Model);
                    Console.WriteLine("Proizvoditel: " + item.Proizvoditel);
                    Console.WriteLine("SerialNumber: " + item.SerialNumber);
                }
            }
        }
    }
}
