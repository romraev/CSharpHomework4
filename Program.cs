// Подготовил Раевский Р.Ю.

// Task 25.

/*int Grade(int a, int b)
{
    int grad = 1;
    for (int i = 1; i<= b; i++)
    {
       grad = grad * a;
    }
    return grad;
}

Console.Write("Enter number A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number B: ");
int B = Convert.ToInt32(Console.ReadLine());

if (B == 0) Console.WriteLine ($"Number {A} in grade {B} equals 1 ");
else Console.WriteLine($"Number {A} in grade {B} equals {Grade(A, B)}");
*/

// Task 27.

int SUM(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + (num % 10);
        num = num / 10;
    }
    return sum;
}

Console.Write("Enter your number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of digits in number {num} equals {SUM(num)}");