// Подготовил Раевский Р.Ю.

// Task 19.

int Grade(int a, int b)
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