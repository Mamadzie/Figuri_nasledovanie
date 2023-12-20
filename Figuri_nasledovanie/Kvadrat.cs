using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures_nasledovanie
{
    internal class Kvadrat : Figures
    {
        protected override int Perimeter_kv()
        {
            Console.WriteLine("Введите первое значение сторони квадрата: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе значение сторони квадрата: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int Perimetr = 4 * a * b;
            Console.WriteLine("Периметр квадрата: " + Perimetr);
            return base.Perimeter_kv();
        }

        protected override int Ploshad_kv()
        {
            Console.WriteLine("Введите первое значение сторони квадрата: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе значение сторони квадрата: ");
            int b = Convert.ToInt32(Console.ReadLine());
            double ploshad = a * b;
            Console.WriteLine("Площадь квадрата = " + ploshad);
            return base.Ploshad_kv();
        }

        public void dostup_Perimeter_kv()
        {
            Perimeter_kv();
        }

        public void dostup_Ploshad_kv()
        {
            Ploshad_kv();
        }

        protected int perimetr_peramidikv;
        protected int ploshad_peramidikv;

        protected virtual int Ploshad_piramidikv()
        {
            return ploshad_peramidikv;
        }

        protected virtual int Perimetr_peramidikv()
        {
            return perimetr_peramidikv;
        }
    }
}
