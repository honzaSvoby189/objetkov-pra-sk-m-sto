using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objetkové_pražské_město
{
    internal class LinkaMetra
    {
        public string nazevLinky { get; set; }
        public bool Aktivní { get; set; }
        public string[] stanice { get; set; }
        public string barva  { get; set; }

        public void VypisVsechnyStanice()
        {
            if(stanice.Length > 0)
            {
                foreach(var JednaStanice in stanice)
                {
                    Console.WriteLine(  JednaStanice);
                }
            }
        }


        public void vypisPosledniStanice()
        {
            if(stanice.Length >= 2)
            {
                Console.WriteLine(stanice[0]);
                Console.WriteLine(stanice[stanice.Length -1]);
            }
        }


        public void NastavStanice()
        {
            if(barva == "zelená")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (barva == "červená")
            {
                Console.ForegroundColor = ConsoleColor.Red;

            }
            else if (barva == "žlutá")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;


            }
            else if (barva == "modrá")
            {
                Console.ForegroundColor = ConsoleColor.Blue;

            }
            Console.WriteLine($" Vítej v lince metra{nazevLinky}");

        }

        public void CasCesty()
        {
            Console.WriteLine("vyber 1 stanicic");
            string prvníStanice = Console.ReadLine();
            int indexPrvni = Array.IndexOf(stanice, prvníStanice);

            Console.WriteLine("-------------------");


            Console.WriteLine("vyber 2 stanicic");
            string DruheStanice = Console.ReadLine();
            int indexDruhe = Array.IndexOf(stanice, DruheStanice);
            Console.WriteLine("-------------------");
            int dobaCesty = (indexPrvni - indexDruhe)*2;

            Console.WriteLine( "Doba cesty" + dobaCesty );
        }
    }
}
