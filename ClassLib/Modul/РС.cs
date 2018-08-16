using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Modul
{
    [Serializable]
    public class PC
    {
        public PC()
        {
            this.Mark = "";
            this.SerialNumber = "";
            this.Proizvoditel = "";
            this.Model = "";
        }
        public PC(string Mark, string SerialNumber, string Proizvoditel,string Model)
        {
            this.Mark = Mark;
            this.SerialNumber = SerialNumber;
            this.Proizvoditel = Proizvoditel;
            this.Model = Model;
        }
        
        public string Mark { get; set; }
        public string SerialNumber { get; set; }
        public string Proizvoditel { get; set; }
        public string Model { get; set; }

        public int id;
    }
}
