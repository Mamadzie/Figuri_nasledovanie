using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures_nasledovanie
{
    internal class Peramida_krug : Circle
    {
        protected override int Peramida_krug_Perimeter()
        {

            Console.WriteLine("Введите радиус основание пирамиды: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите количество рёбр на основание пирамиды: ");
            int n = int.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * radius / n;
            Console.WriteLine("Периметр конусной пирамиды: " + perimeter);
            return base.Peramida_krug_Perimeter();
        }

        protected override int Peramida_krug_Ploshad()
        {
            Console.WriteLine("Введите радиус основы конусной пирамиды:");
            double radiusBase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите радиус вершины конусной пирамиды:");
            double radiusVertex = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите высоту конусной пирамиды:");
            double heightPyramid = Convert.ToDouble(Console.ReadLine());

            double surfaceAreaCone = Math.PI * Math.Pow(radiusBase, 2);

            double slantHeight = Math.Sqrt(Math.Pow(heightPyramid, 2) + Math.Pow(radiusVertex - radiusBase, 2));

            double surfaceAreaLateral = Math.PI * (radiusBase + radiusVertex) * slantHeight;

            double totalSurfaceArea = surfaceAreaCone + surfaceAreaLateral;

            Console.WriteLine("Площадь конусной пирамиды: " + totalSurfaceArea);
            return base.Peramida_krug_Ploshad();
        }

        public void dostup_perimeter_Peramidi_kruga()
        {
            Peramida_krug_Perimeter();
        }

        public void dostup_ploshad_peramidi_kruga()
        {
            Peramida_krug_Ploshad();
        }
    }
}
