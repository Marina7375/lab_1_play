using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Среднее арифметическое 1" +'\n'+
                "Сумма членов ряда 2 " + '\n' +
                "Функция с ошибкой исчеслений 3");
            int s = int.Parse(Console.ReadLine());
            if (s == 1)
            {
                Console.WriteLine('\n'+"Среднее арифметическое" + '\n');
  
                  Console.WriteLine("Введите 1 число");
                int k = int.Parse(Console.ReadLine());


                Console.WriteLine("Введите 2 число");
                int x = int.Parse(Console.ReadLine());
                int my_result = MyLib.MyClass.Sred(k, x);

                Console.WriteLine("Среднее={0}", my_result);
            }
            if (s == 2)
            {
                Console.WriteLine('\n'+"Сумма членов ряда" + '\n');
                Console.WriteLine("Введите степень");
                    double n = int.Parse(Console.ReadLine());
                if (n == 0) { Console.WriteLine("Степень не может быть =0"); }
                else
                {

                    Console.WriteLine("Введите x");
                    int x = int.Parse(Console.ReadLine());
                    double my_suma = MyLib.MyClass.Suma(n, x);
                    Console.WriteLine("Сума членов ряда={0}", my_suma);
                }
            }
            if (s == 3)
            {
                Console.WriteLine('\n'+"Функция с ошибкой исчеслений" + '\n');
                Console.WriteLine("Введите  x");
                double n = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите значение точности ");
                double x = double.Parse(Console.ReadLine());

                // call the F calculation method from the library
                double my_f_obch = Math.Round(MyLib.MyClass.F_obch(n, x), 4);
                // calculating the exact value of the function

                double sh_x = Math.Round((Math.Exp(x)+ Math.Exp(-x))/2, 4);
                // calculation error

                double t = Math.Round(Math.Abs(my_f_obch - sh_x) / sh_x * 100, 3);
                Console.WriteLine("my_f_obch={0}, sh_x={1}, t={2}%", my_f_obch, sh_x, t);
                Console.ReadKey();
            }


                Console.ReadKey();
            
        }
    }
}
