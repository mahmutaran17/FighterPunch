using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example.Models
{
    public class Fighter
    {
        public string OyuncuIsmi { get; set; }
        public string Brans { get; set; }
        public string Irk { get; set; }
        public string Silah { get; set; }
        public int PunchingPower { get; set; }

        public void Punch()
        {
            switch (Brans)
            {
                case "uppercut":
                    PunchingPower = 50;
                    break;
                case "block":
                    PunchingPower = 10;
                    break;
                default:
                    PunchingPower = 30;
                    break;

            }

        }
    }
}
