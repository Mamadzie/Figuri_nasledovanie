using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures_nasledovanie
{
    internal class Piramida : Figures
    {
        protected override int Ploshad_piramidi()
        {
            Console.WriteLine("Введите высоту пирамиды: ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону пирамиды: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int ploshad = (h * 4) + (h * a / 2);
            Console.WriteLine("Площадь пирамиды: " + ploshad);
            return base.Ploshad_piramidi();
        }

        protected override int Perimetr_piramidi()
        {
            Console.WriteLine("Введите длину пирамиды: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ширину пирамиды: ");
            int s = Convert.ToInt32(Console.ReadLine());
            double side = 2 * s + 2 * Math.Sqrt(2) * s;
            Console.WriteLine("Периметр пирамиды: " + side);
            return base.Perimetr_piramidi();
        }

        protected override int Obyom_piramidi()
        {
            Console.WriteLine("Введите высоту пирамиды: ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону пирамиды: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите объем пирамиды: ");
            int v = Convert.ToInt32(Console.ReadLine());
            double obyom = (1.0 / 3.0) * a * a * h;
            Console.WriteLine("Объем пирамиды: " + obyom);
            return base.Obyom_piramidi();
        }

        public void dostup_Ploshad_piramidi()
        {
            Ploshad_piramidi();
        }
        public void dostup_Perimetr_piramidi()
        {
            Perimetr_piramidi();
        }
        public void dostup_Obyom_piramidi()
        {
            Obyom_piramidi();
        }
    }
}
