using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures_nasledovanie
{
    internal class Figures
    {
        protected int Perimetr;
        protected int Ploshad;

        protected virtual int Perimeter_kv()
        {
            return Perimetr;
        }

        protected virtual int Ploshad_kv()
        {
            return Ploshad;
        }

        protected int radius_perimetr;
        protected int radius_ploshad;
        protected virtual int Perimetr_r()
        {
            return radius_perimetr;
        }
        protected virtual int Ploshad_r()
        {
            return radius_ploshad;
        }

        protected int rac_perimetr;
        protected int rac_ploshad;

        protected virtual int Perimetr_rectangle()
        {
            return rac_perimetr;
        }

        protected virtual int Ploshad_rectangle()
        {
            return rac_ploshad;
        }


        protected int triangle_ploshad;
        protected int triangle_perimetr;

        protected virtual int Ploshad_triangle()
        {
            return triangle_ploshad;
        }

        protected virtual int perimetr_triangel()
        {
            return triangle_perimetr;
        }

        protected int piramida_ploshad;
        protected int piramida_perimetr;
        protected int piramida_obyom;

        protected virtual int Ploshad_piramidi()
        {
            return piramida_ploshad;
        }

        protected virtual int Perimetr_piramidi()
        {
            return piramida_perimetr;
        }

        protected virtual int Obyom_piramidi()
        {
            return piramida_obyom;
        }
    }
}