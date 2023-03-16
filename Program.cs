

// Задача 1

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.Write("input number: ");
string? number = Console.ReadLine();

void IsPalindrome(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Your number: {number} -is palindrome.");
  }
  else Console.WriteLine($"Your number : {number} - no palindrome.");
}

if (number!.Length == 5)
{
  IsPalindrome(number);
}

else Console.WriteLine($"Input currect number ");



// Задача 2

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


//  Double Decision(double x1 ,double y1, double z1, double x2 , double y2, double z2)
// {
//   return Math.Round (Math.Sqrt(Math.Pow(x2 -x1 ,2) + Math.Pow(y2-y1 ,2) + Math.Pow(z2-z1 ,2)), 2);
// }
//  Console.WriteLine(" Input cordinate X of A point");
//  double x1 = Convert.ToDouble(Console.ReadLine());
//  Console.WriteLine(" Input cordinate Y of A point");
//  double y1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine(" Input cordinate Z of A point");
//  double z1 = Convert.ToDouble(Console.ReadLine());
//  Console.WriteLine(" Input cordinate X of B point");
//  double x2 = Convert.ToDouble(Console.ReadLine());
//  Console.WriteLine(" Input cordinate Y of B point");
//  double y2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine(" Input cordinate Z of B point");
//  double z2 = Convert.ToDouble(Console.ReadLine());


// double segmentLength = Decision(x1 ,y1, z1,  x2, y2 ,z2);
//  Console.WriteLine($"segmentLength A and B is {segmentLength}");






//Задача 3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Input number: ");
// int cube = Convert.ToInt32(Console.ReadLine());

// void Cube(int[] cube)
// {
//   int i = 0;
//   int length = cube.Length;
//   while (i <  length)
//   {
//     cube[i] = Convert.ToInt32(Math.Pow(i, 3));
//     i++;
//   }
// }

// void PrintArry(int[] coll)
// {
//   int count = coll.Length;
//   int index = 1;
//   while(index < count)
//   {
//     Console.Write(coll[index]+ " ");
//     index++;
//   }
// } 

// int[] arry = new int[cube+1];
// Cube(arry);
// PrintArry(arry);


