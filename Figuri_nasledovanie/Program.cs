using Figures_nasledovanie;
using System;

class programP
{
    static void Main(string[] args)
    {
        Kvadrat kv = new Kvadrat();
        Circle cir = new Circle();
        Rectangle rac = new Rectangle();
        Triangle triangle = new Triangle();
        Piramida p = new Piramida();
        Piramida_kv p_kv = new Piramida_kv();
        Peramida_krug p_krug = new Peramida_krug();
        Piramida_triangle p_tri = new Piramida_triangle();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("          _________________");
        Console.WriteLine("         |Выберите действие|");
        Console.WriteLine(" ___________________________________________");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("|1. -> Вывести площадь квадрата.            |");
        Console.WriteLine("|2. -> Вывести периметр квадрата.           |");
        Console.WriteLine("|3. -> Вывести площадь круга.               |");
        Console.WriteLine("|4. -> Вывести периметр круга.              |");
        Console.WriteLine("|___________________________________________|");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("|5. -> Вывести площадь прямоугольника.      |");
        Console.WriteLine("|6. -> Вывести перметр прямоугольника.      |");
        Console.WriteLine("|7. -> Вывести площадь треугольника.        |");
        Console.WriteLine("|8. -> Вывести периметр треугольника.       |");
        Console.WriteLine("|___________________________________________|");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("|9. -> Вывести площадь пирамиды.            |");
        Console.WriteLine("|10.-> Вывести периметр пирамиды.           |");
        Console.WriteLine("|11.-> Вывести объём пирамиды.              |");
        Console.WriteLine("|12.-> Вывести площадь пирамиды квадрата    |");
        Console.WriteLine("|___________________________________________|");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("|13.-> Вывести периметр пирамиды квадрата   |");
        Console.WriteLine("|14.-> Вывести периметр конусной пирамиды   |");
        Console.WriteLine("|15.-> Вывести площадь конусной пирамиды    |");
        Console.WriteLine("|16.-> Вывести периметр треугольной пирамиды|");
        Console.WriteLine("|17.-> Вывести площадь треугольной пирамиды |");
        Console.WriteLine("|___________________________________________|");
        Console.ForegroundColor = ConsoleColor.White;
        int choice = Convert.ToInt32(Console.ReadLine());


        switch (choice)
        {
            case 1:
                Console.WriteLine("Для вывода площадь квадрата введите следующее.");
                kv.dostup_Ploshad_kv();
                break;
            case 2:
                Console.WriteLine("Для вывода периметр квадрата введите следующее.");
                kv.dostup_Perimeter_kv();
                break;
            case 3:
                Console.WriteLine("Для вывода площадь круга введите следующее.");
                cir.dostup_Ploshad_r();
                break;
            case 4:
                Console.WriteLine("Для вывода периметр круга введите следующее.");
                cir.dostup_Perimetr_r();
                break;
            case 5:
                Console.WriteLine("Для вывода площадь прямоугольника введите следующее.");
                rac.dostup_Ploshad_rectangle();
                break;
            case 6:
                Console.WriteLine("Для вывода периметр прямоугольника введите следующее.");
                rac.dostup_Perimetr_rectangle();
                break;
            case 7:
                Console.WriteLine("Для вывода площадь треугольника введите следующее.");
                triangle.dostup_Ploshad_triangle();
                break;
            case 8:
                Console.WriteLine("Для вывода периметр треугольника введите следующее.");
                triangle.dostup_perimetr_triangel();
                break;
            case 9:
                Console.WriteLine("Для вывода площадь пирамиды введите следующее.");
                p.dostup_Ploshad_piramidi();
                break;
            case 10:
                Console.WriteLine("Для вывода периметра пирамиды введите следующее.");
                p.dostup_Perimetr_piramidi();
                break;
            case 11:
                Console.WriteLine("Для вывода объём пирамиды введите следующее.");
                p.dostup_Obyom_piramidi();
                break;
            case 12:
                Console.WriteLine("Для вывода площади пирамиды квадрата введите следующее.");
                p_kv.dostup_Ploshad_piramidikv();
                break;
            case 13:
                Console.WriteLine("Для вывода периметра пирамиды квадрата введите следующее.");
                p_kv.dostup_Perimetr_peramidikv();
                break;
            case 14:
                Console.WriteLine("Для вывода периметра конусной пирамиды введите следующее.");
                p_krug.dostup_perimeter_Peramidi_kruga();
                break;
            case 15:
                Console.WriteLine("Для вывода площади конусной пирамиды введите следующее.");
                p_krug.dostup_ploshad_peramidi_kruga();
                break;
            case 16:
                Console.WriteLine("Для вывода периметра треугольной пирамиды введите следующее.");
                p_tri.dostup_Peramida_perimeter_triangle();
                break;
            case 17:
                Console.WriteLine("Для вывода площади треугольной пирамиды введите следующее.");
                p_tri.dostup_Peramida_ploshad_triangle();
                break;
            default:
                Console.WriteLine("Ошибка");
                break;
        }

    }
}