using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class Transakcija
    {
        public int Id { get; set; }
        public int BrojRacuna { get; set; }
        public string Tip { get; set; }
        public float Iznos { get; set; }
        public DateTime Datum { get; set; }
    }
}
