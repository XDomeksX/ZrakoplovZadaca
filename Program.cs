using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zrakoplov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zrakoplov x380 = new Zrakoplov("Airbus", 2000, 6000);
            Console.WriteLine(x380.ToString() + "\n");
            Zrakoplov C162 = new Zrakoplov("Cessna Skycatcher", 75, 870);
            Console.WriteLine(C162.ToString() + "\n");
            Zrakoplov PC_21 = new Zrakoplov("Pilatus", 1200, 1333);
            Console.WriteLine(PC_21.ToString());

            Console.ReadKey();
        }
    }
    class Zrakoplov
    {
        String naziv;
        int snaga, doseg;

        public override string ToString()
        {
            string ispis = "Naziv: " + getnaziv() + "\n"
                + "Snaga motora: " + getsnaga() + " kW" + "\n"
                + "Doseg leta: " + getdoseg() + " km";
            return ispis;
        }

        public Zrakoplov()
        { }

        public Zrakoplov(string naziv, int snaga, int doseg)
        {
            this.naziv = naziv;
            this.snaga = snaga;
            this.doseg = doseg;
        }

        private void setnaziv(string naziv)
        {
            this.naziv = naziv;
        }
        private void setsnaga(int snaga)
        {
            this.snaga = snaga;
        }
        private void setdoseg(int doseg)
        {
            this.doseg = doseg;
        }
        public string getnaziv()
        {
            return this.naziv;
        }
        public int getsnaga()
        {
            return this.snaga;
        }
        public int getdoseg()
        {
            return this.doseg;
        }
    }
}
