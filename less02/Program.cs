// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите любое целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

  int SumNum(int num){
    
    int counter = num;
    int advance = 0;
    int res = 0;

    for (int i = 0; i < counter; i++){
      advance = num - num % 10;
      res = res + (num - advance);
      num = num / 10;
    }
   return res;
  }

int sumnum = SumNum(num);
Console.WriteLine("Сумма цифр в числе: " + sumnum);