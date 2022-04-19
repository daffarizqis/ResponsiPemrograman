using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4297
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No\tNik/Nama \t\t\t Gaji Bulanan");
			Console.WriteLine("-------------------------------------------------");
		
             Karyawan karyawan1 = new Karyawan(19112689, "Paijo", 3000000);
		     Karyawan karyawan2 = new Karyawan(19112688, "Jono", 2000000);

			
            karyawan1.PrintAndShow();
			karyawan2.PrintAndShow();

			Console.WriteLine("\n\n Asyiiiiiikk Kenaikan Gaji 10%!!");
            Console.WriteLine("No\tNik/Nama \t\t\t Gaji Bulanan");
            Console.WriteLine("-------------------------------------------------");


            karyawan1.getdapetbonus();
            karyawan2.getdapetbonus();
            
            
        }
    }
}
