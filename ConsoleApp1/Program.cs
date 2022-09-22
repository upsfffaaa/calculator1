using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Калькулятор
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double a;
			double b;
			byte x = 0;
			double res;


			Console.WriteLine("Введите номер операции");
			Console.WriteLine(" ");
			Console.WriteLine("1. сложение");
			Console.WriteLine("2. вычитыние");
			Console.WriteLine("3. умножение");
			Console.WriteLine("4. деление");
			Console.WriteLine("5. степень");
			Console.WriteLine("6. квадратный корень");
			Console.WriteLine("7. 1 процент");
			Console.WriteLine("8. факториал");
			Console.WriteLine("9. выход");

			while (x != 9)
			{
				x = Convert.ToByte(Console.ReadLine());
				if (x < 1 || x > 9) Console.WriteLine("Вы ввели неподходящий номер операции, введите числа от 1 до 9");
				switch (x)
				{
					case 1:
						{
							Console.WriteLine("Введите первое число");
							a = Convert.ToDouble(Console.ReadLine());
							Console.WriteLine("Введите второе число");
							b = Convert.ToDouble(Console.ReadLine());
							res = a + b;
							Console.Write("Результат: ");
							Console.WriteLine(res);
							break;
						}
					case 2:
						{
							Console.WriteLine("Введите первое число");
							a = Convert.ToDouble(Console.ReadLine());
							Console.WriteLine("Введите второе число");
							b = Convert.ToDouble(Console.ReadLine());
							res = a - b;
							Console.Write("Результат: ");
							Console.WriteLine(res);
							break;
						}
					case 3:
						{
							Console.WriteLine("Введите первое число");
							a = Convert.ToDouble(Console.ReadLine());
							Console.WriteLine("Введите второе число");
							b = Convert.ToDouble(Console.ReadLine());
							res = a * b;
							Console.Write("Результат: ");
							Console.WriteLine(res);
							break;
						}
					case 4:
						{
							Console.WriteLine("Введите первое число");
							a = Convert.ToDouble(Console.ReadLine());
							Console.WriteLine("Введите второе число");
							b = Convert.ToDouble(Console.ReadLine());
							if (b == 0) Console.WriteLine("На ноль делить нельзя");
							else
							{
								res = a / b;
								Console.Write("Результат: ");
								Console.WriteLine(res);
							}
							break;

						}
					case 5:
						{
							Console.WriteLine("Введите число");
							a = Convert.ToDouble(Console.ReadLine());
							Console.WriteLine("Введите степень");
							b = Convert.ToDouble(Console.ReadLine());
							res = Math.Pow(a, b);
							Console.Write("Результат: ");
							Console.WriteLine(res);
							break;
						}
					case 6:
						{
							Console.WriteLine("Введите число");
							a = Convert.ToDouble(Console.ReadLine());
							res = Math.Sqrt(a);
							Console.Write("Результат: ");
							Console.WriteLine(res);
							break;
						}
					case 7:
						{
							Console.WriteLine("Введите число");
							a = Convert.ToDouble(Console.ReadLine());
							res = a / 100;
							Console.Write("Результат: ");
							Console.WriteLine(res);
							break;
						}
					case 8:
						{
							Console.WriteLine("Введите число");
							a = Convert.ToDouble(Console.ReadLine());
							res = 1;
							for (int i = 1; i <= a; i++)
							{
								res *= i;
							}
							Console.Write("Результат: ");
							Console.WriteLine(res);
							break;
						}


				}
			}
			Console.WriteLine("Вы закрыли программу");
		}
	}
}
