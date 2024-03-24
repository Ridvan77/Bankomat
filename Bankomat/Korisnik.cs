using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Bankomat
{
    public class Korisnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Sifra { get; set; }
        public string Email { get; set; }
        public bool Spol { get; set; }
        public string Posao { get; set; }
        public DateTime Dob { get; set; }
        public float StanjeRacuna { get; set; }
    }
}
