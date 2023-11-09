//20 var

Console.Write("Введите натуральное число n: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());

int count = 0;
int k = n;
int temp = n;
int sum = 0;

while (count != m)
{
    int j = temp % 10;
    sum += j;
    temp /= 10;
    count++;
}

Console.WriteLine($"Сумма {m} последних цифр числа {n} равна: {sum}");