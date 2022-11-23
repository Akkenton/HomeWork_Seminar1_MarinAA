// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

//---------  START -----------
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int count = 0; // переменная в цикле, в которую будет записывать шаг +/- 2
if (num == 1)
{
    Console.WriteLine("Так как число является 1, то целого четного числа от 1 до 1 по условиям задачи не существует!");
}
else
{
    if (num > 1)
    {
        count = count + 2;
        while (count <= num)
        {
            Console.Write(count + " ");
            count = count + 2;
        }
    }
    if (num <= 0) //ноль в математике четное число
    {
        while (count >= num)
        {
            Console.Write(count + " ");
            count = count - 2;
        }
    }
}


//---------  END -------------