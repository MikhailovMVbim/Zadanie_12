using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:
    метод, определяющий длину окружности по заданному радиусу;
    метод, определяющий площадь круга по заданному радиусу;
    метод, проверяющий принадлежность точки с координатами (x,y) кругу с радиусом r и координатами центра x0, y0. 
 */

namespace Zadanie_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Статический класс для работы с окружностью");
            Console.WriteLine("------------------------------------------");
            try
            {
                Console.WriteLine("Расчет длины и площади");
                Console.Write("Введите радиус:");
                Circle.radius = Convert.ToDouble(Console.ReadLine());
                Circle.GetCircleLenght();
                Circle.GetCircleArea();
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Проверка придлежности точки кругу");
                Console.Write("Введите Х-координату точки:");
                Circle.x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите Y-координату точки:");
                Circle.y = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите Xo-координату центра круга:");
                Circle.x0 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите Yo-координату центра круга:");
                Circle.y0 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Circle.IsPointInCircle();
                Console.ReadKey();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
    static class Circle
    {
        public static double radius;
        public static double x;
        public static double y;
        public static double x0;
        public static double y0;

        public static void GetCircleLenght ()
        {
            Console.WriteLine("Длина окружности с R={0} равна {1:f2}",radius,2* Math.PI*radius);
        }
        public static void GetCircleArea ()
        {
            Console.WriteLine("Площадь круга с R={0} равна {1:f2}", radius,Math.PI * radius * radius);
        }
        public static void IsPointInCircle ()
        {
            if (((x0-x)*(x0 - x) + (y0-y)*(y0 - y))<=radius*radius)
            {
                Console.WriteLine("Точка с координатами ({0},{1}) ПРИНАДЛЕЖИТ кругу с радиусом {2} и координатами центра ({3},{4})",x,y,x0,y0,radius);
            }
            else
            {
                Console.WriteLine("Точка с координатами ({0},{1}) находится ВНЕ круга с радиусом {2} и координатами центра ({3},{4})", x, y, x0, y0, radius);
            }
        }

    }
}
