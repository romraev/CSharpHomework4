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

/* int SUM(int num)
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
*/

//Task 29.

/* int[] CreateRandomArray(int size, int minvalue, int maxvalue)
{
    int[] array = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minvalue, maxvalue + 1);
    }
    return array;
}

void WriteArray(int[]array)
{
    for(int i=0; i<array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.Write("input min value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("input min value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
WriteArray(myArray);
*/