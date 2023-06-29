//Task 1 Два числа и выдать макс/мин

Console.WriteLine("Введите первое число: ");
            int num_A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int num_B = Convert.ToInt32(Console.ReadLine());

            if (num_A > num_B)
            {
                Console.WriteLine("Первое число " + num_A + " больше чем второе " + num_B);
            }
            else
            {
                Console.WriteLine("Второе число " + num_B + " больше чем первое " + num_A);
            }
            
//Task 2. Три числа
Console.WriteLine ("Введите три числа: ");
int num_1 =Convert.ToInt32(Console.WriteLine());
int num_2 =Convert.ToInt32(Console.WriteLine());
int num_3 =Convert.ToInt32(Console.WriteLine());
int max = num_1;

if (num_2 > max)
{
max = num_2;
}

 if (num_3 > max)
{
    max = num_3;
}

Console.WriteLine("Наибольшее из введённых чисел -> " + max);

//Task 3.
Console.WriteLine("Введите число:");
num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 1)
{
    Console.WriteLine("Число " + num + " является: нечетным");
}
else
{
Console.WriteLine("Число " + num + "является: четным");
}

//Task 4
int i = 1;
bool not = true;

Console.WriteLine("Введите число:");
num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Чётные числа от 1 до " + num);
while (i <= num)
{
     if (i % 2 != 1)
    {
        Console.Write(i + ", ");
        not = false;
                }
     i++;
}

if (not)
{
    Console.WriteLine("Нет чётных чисел!);
}