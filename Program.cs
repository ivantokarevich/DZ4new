/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число А в натуральную степень В*/

/* Console.Clear();

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(func(a,b));

int func (int firstNumber, int secondNumber)
{
    int c=1;
    for(int i = 1; i<=secondNumber; i++)
    {
        c=c*firstNumber;
    }
    return c;
} */

/*Задача 27: Напишите программу, которая принимает на вход число и выдает сумму цифр в числе*/

/* Console.Clear();

Console.WriteLine("Введите число");
string num = Console.ReadLine();
Console.WriteLine("Сумма цифр введенного числа равна " + SumOfNumbers(num));


int SumOfNumbers(string number)
{
    //string to char
    int sum=0;
    char[] charArray = number.ToCharArray();

    //char to int
    int[] intArray = new int[charArray.Length];
    for(int i =0; i<charArray.Length; i++)
    {
        intArray[i]=charArray[i]-'0';
        sum=sum+intArray[i];
  
    }
    return sum;
} */



/*Задача 29. Напишите программу, которая задает массив из 8 элементов и выводит их на экран*/

Console.Clear();

int[] array = new int[8];
for(int i=0; i<array.Length; i++)
{
    int number = new Random().Next(1,100);
    array[i] = number;
    Console.Write(array[i] + ", ");
}