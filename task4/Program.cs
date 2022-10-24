// ; Задача 25: Используя определение степени числа, напишите цикл, 
// ; который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
// ; 3, 5 -> 243 (3⁵)
// ; 2, 4 -> 16

void Zadacha25()
{
    int stepen = 1;

    Console.WriteLine("Введите 1 число:");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите 2 число:");
    int num1 = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= num1; i++)
    {
        stepen *= num;
    }

    Console.Write($"Число {num} в степени {num1} = {stepen}");
    Console.WriteLine();


}
// Zadacha25();

// Задача 27: Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе.

void Zadacha27()
{
    Console.WriteLine("___________________________");
    Console.WriteLine("Задача 27");
    Console.WriteLine("Введите число:");

    int number = Convert.ToInt32(Console.ReadLine());
    int sum = 0;

    while (number > 0)
    {
        sum = sum + number % 10;
        number /= 10;
    }
    Console.WriteLine($"Сумма цифр в числе = {sum} ");

}
// Zadacha27();

// Задача 29: Напишите программу, которая задаёт массив из 
// 8 случайных целых чисел и выводит отсортированный по модулю массив.

void Zadacha29()
{
    Console.WriteLine("___________________________");
    Console.WriteLine("Задача 29");
  
   Random random = new Random();
    int size = 8;
    int[] numbers = new int[size];
    int temp = 0;

    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine();
}

void FillArray(int[]num)
{
    Random random = new Random();
    for (int i = 0; i<num.Length; i++)
    {
        num[i] = random.Next(0, 10);
 
    }
}
    void PrintArray(int[]num)
{
    Random random = new Random();
    for (int i = 0; i<num.Length; i++)
    {
        Console.Write(num[i]+ "  ");
    }
}
   
     Zadacha29 ();


        //     for (int i = 0; i < arr.Length; i++)
        //         for (int j = i + 1; j < arr.Length; j++)
        //             if (arr[j] < arr[i])
        //             {
        //                 var temp = arr[j];
        //                 arr[j] = arr[i];
        //                 arr[i] = temp;
        //             }
        // }
 
        // static void Main(string[] args)
        // {
        //     Random rand = new Random();
        //     int[] mass = new int[100];
        //     for (int i = 0; i < 100; i++)
        //     {
        //         mass[i] = rand.Next(1, 100);
        //         Console.WriteLine("[" + i + "] " + mass[i]);
        //     }
 
        //     Console.WriteLine("После сортировки:");
        //     BubbleSort(mass);
        //     for (int i = 0; i < 100; i++)
        //         Console.WriteLine("[" + i + "] " + mass[i]);
            
        // }
