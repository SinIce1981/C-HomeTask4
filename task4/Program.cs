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
    for ( int i = 1; i <=num1; i++)
        // Console.Write($"{i}" );
        stepen *= num;

    Console.Write($"{stepen}" );
    Console.WriteLine();
    

}
Zadacha25();