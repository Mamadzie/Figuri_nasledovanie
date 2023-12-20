using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Figures_nasledovanie
{
    internal class Piramida_triangle : Triangle
    {
        protected override int Peramida_perimeter_triangle()
        {
            Console.WriteLine("Введите длину стороны A треугольного основания:");
            double sideA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите длину стороны B треугольного основания:");
            double sideB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите длину стороны C треугольного основания:");
            double sideC = Convert.ToDouble(Console.ReadLine());

            double perimeter = sideA + sideB + sideC;

            Console.WriteLine("Периметр треугольной пирамиды: " + perimeter);

            return base.Peramida_perimeter_triangle();
        }

        protected override int Peramida_ploshad_triangle()
        {
            Console.WriteLine("Введите площадь треугольного основания пирамиды:");
            double baseArea = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите длину стороны A треугольного основания:");
            double sideA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите длину стороны B треугольного основания:");
            double sideB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите длину стороны C треугольного основания:");
            double sideC = Convert.ToDouble(Console.ReadLine());

            double perimeter = (sideA + sideB + sideC) / 2;
            double lateralSurfaceArea = Math.Sqrt(perimeter * (perimeter - sideA) * (perimeter - sideB) * (perimeter - sideC));
            double totalSurfaceArea = baseArea + lateralSurfaceArea;

            Console.WriteLine("Площадь поверхности треугольной пирамиды: " + totalSurfaceArea);

            return Peramida_perimeter_triangle();
        }

        public void dostup_Peramida_perimeter_triangle()
        {
            Peramida_perimeter_triangle();
        }

        public void dostup_Peramida_ploshad_triangle()
        {
            Peramida_ploshad_triangle();
        }




    }
}
