using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures_nasledovanie
{
    internal class Rectangle : Figures
    {
        protected override int Perimetr_rectangle()
        {
            Console.WriteLine("Введите длину: ");
            int sideC = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ширину: ");
            int sideD = Convert.ToInt32(Console.ReadLine());
            int perimeter = 2 * (sideC + sideD);
            Console.WriteLine("Периметр прямоугольника = " + perimeter);
            return base.perimetr_triangel();
        }

        protected override int Ploshad_rectangle()
        {
            Console.WriteLine("Введите длину: ");
            int sideA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Ширину: ");
            int sideB = Convert.ToInt32(Console.ReadLine());
            int area = sideA * sideB;
            Console.WriteLine("Площадь прямоугольника = " + area);
            return Ploshad_rectangle();
        }

        public void dostup_Perimetr_rectangle()
        {
            Perimetr_rectangle();
        }

        public void dostup_Ploshad_rectangle()
        {
            Ploshad_rectangle();
        }
    }
}
