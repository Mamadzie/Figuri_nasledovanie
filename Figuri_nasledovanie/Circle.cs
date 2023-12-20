using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures_nasledovanie
{
    internal class Circle : Figures
    {
        protected override int Perimetr_r()
        {
            Console.WriteLine("Введите радиус круга: ");
            int b = Convert.ToInt32(Console.ReadLine());
            double perimiter = Math.PI * Math.Pow(b, 2);
            Console.WriteLine("Периметр круга = " + perimiter);
            return base.Perimetr_r();
        }
        protected override int Ploshad_r()
        {
            Console.WriteLine("Введите радиус круга: ");
            int a = Convert.ToInt32(Console.ReadLine());
            double ploshad = Math.PI * Math.Pow(a, 2); //Pi число П Pow возведение в степени
            Console.WriteLine("Площадь круга = " + ploshad);
            return base.Ploshad_r();
        }

        public void dostup_Perimetr_r()
        {
            Perimetr_r();
        }
        public void dostup_Ploshad_r()
        {
            Ploshad_r();
        }

        protected int Perimeter_Peramidi_krug;
        protected int Ploshad_Peramidi_krug;

        protected virtual int Peramida_krug_Perimeter()
        {
            return Perimeter_Peramidi_krug;
        }

        protected virtual int Peramida_krug_Ploshad()
        {
            return Ploshad_Peramidi_krug;
        }
    }
}
