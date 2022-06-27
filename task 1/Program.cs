System.Console.Write("Ведите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    System.Console.Write(num1);
    System.Console.WriteLine("Первое число больше");
}
else if (num2 > num1)
{
    System.Console.Write(num2);
    System.Console.WriteLine("Второе число больше");
}
else
{
    System.Console.WriteLine("Числа равны");
}