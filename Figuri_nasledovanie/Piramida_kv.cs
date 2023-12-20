using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Figures_nasledovanie
{
    internal class Piramida_kv : Kvadrat
    {
        protected override int Ploshad_piramidikv()
        {

            Console.WriteLine("Введите длину стороны основания пирамиды: ");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите высоту пирамиды: ");
            int osn = int.Parse(Console.ReadLine());

            double ploshad_osn = length * length; //Площадь основание пирамиды
            double bok = 2 * length * osn; //Боковая поверхность пирамиды
            double totalarea = ploshad_osn + bok;
            Console.WriteLine("Площадь пирамиды квадрата: " + totalarea);
            return base.Ploshad_piramidikv();
        }

        protected override int Perimetr_peramidikv()
        {
            Console.WriteLine("Введите длину стороны квадрата");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество боковых граней: ");
            int col_bok = int.Parse(Console.ReadLine());

            int perimetr = length * col_bok;
            Console.WriteLine("Периметр пирамиды");
            return base.Perimetr_peramidikv();
        }


        public void dostup_Perimetr_peramidikv()
        {
            Perimetr_peramidikv();
        }

        public void dostup_Ploshad_piramidikv()
        {
            Ploshad_piramidikv();
        }
    }
}
