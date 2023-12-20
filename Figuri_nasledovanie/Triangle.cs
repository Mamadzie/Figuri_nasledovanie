using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures_nasledovanie
{
    internal class Triangle : Figures
    {
        protected override int Ploshad_triangle()
        {

            Console.Write("Введите сторону А: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону В: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону С: ");
            int c = Convert.ToInt32(Console.ReadLine());

            double p = (a + b + c) / 2;
            double s = (double)Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine("Площадь треугольника равна = " + s);

            if (a + b <= c || a + c <= b || b + c <= a)
                Console.WriteLine("Это не треугольник!");
            else if (a == b && b == c)
                Console.WriteLine("Это равносторонний треугольник!");
            else if (a == b || a == c || b == c)
                Console.WriteLine("Это равнобедренный треугольник!");
            else
                Console.WriteLine("Это треугольник.");
            return base.Ploshad_triangle();
        }

        protected override int perimetr_triangel()
        {
            Console.Write("Введите сторону А: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону В: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону С: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int res = a + b + c;
            Console.WriteLine("Периметр треугольника = " + res);
            return base.perimetr_triangel();
        }

        public void dostup_Ploshad_triangle()
        {
            Ploshad_triangle();
        }

        public void dostup_perimetr_triangel()
        {
            perimetr_triangel();
        }

        protected int perimeter_peramidi_triangle;
        protected int ploshad_peramidi_triangle;

        protected virtual int Peramida_perimeter_triangle()
        {
            return perimeter_peramidi_triangle;
        }

        protected virtual int Peramida_ploshad_triangle()
        {
            return ploshad_peramidi_triangle;
        }
    }
}
