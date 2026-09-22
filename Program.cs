// int number = int.Parse(Console.ReadLine()!);

// switch(number)
// {
//    case 1: Console.WriteLine("Начало");
//       break;
//    case 2: Console.WriteLine("Середина");
//       break;
//    default: Console.WriteLine("Другое значение");
//       break;
// }


// int day = int.Parse(Console.ReadLine());
// switch (day)
// {
//    case 6 or 7: Console.WriteLine("Выходной");
//       break;
//    default:
//       Console.WriteLine("Будний");
//       break;
// }




// using System.Collections;

// int temperature = int.Parse(Console.ReadLine());

// switch (temperature)
// {
//    case <= 0:
//       Console.WriteLine("");
// }



// using System.Reflection.Metadata;

// int score = 50;
// string result = score switch
// {
//    >= 91 => "Отлично",
//    >= 71 => "Хорошо",
//    >= 51 => "Удовлетворительно",
//    _ => "Неудовлетворительно",
// };
// Console.WriteLine(result);



// string role = Console.ReadLine()!;
// switch (role)
// {
//    case "admin":
//       Console.WriteLine("Полный доступ");
//       break
// }



// int age = int.Parse(Console.ReadLine());
// bool hasTicket = true;
// switch (age)
// {
//    case >= 18 when hasTicket:
//       Console.WriteLine("Вход разрешен");
//       break;
//    case <= 18:
//       Console.WriteLine("У вас нет билета");
//       break;
//    default:
//       Console.WriteLine("Вход запрещен");
//       break
// }



// switch (number)
// {
//    case 1: Console.WriteLine("Начало");
//       break;
//    case 2: Console.WriteLine("Середина");
//       break;
//    default: Console.WriteLine("Другое значение");
//       break;
// }



int level = 2;

switch (level)
{
   case 1:
      Console.WriteLine("Начальный уровень");
      break;
   case 2:
      Console.WriteLine("Средний уровень");
      goto case 1;
   case 3:
      Console.WriteLine("Продвинутый уровень");
      break;
}



int day = int.Parse(Console.ReadLine());
switch (day)
{
   case 6 or 7 or 5:
      Console.WriteLine("Выходной");
      break;
   default:
      Console.WriteLine("Будний");
      break;
}





int score = 78;
switch(score)
{
   case >= 0 and < 39:
      Console.WriteLine("Неудовлетворительно");
      break;
   case >= 40 and < 59:
      Console.WriteLine("Удовлетворительно");
      break;
   case >= 60 and < 79:
      Console.WriteLine("Хорошо");
      break;
   case >= 80 and <= 100:
      Console.WriteLine("Отлично");
      break;
   default:
   Console.WriteLine("Некорректный балл");
break;

};



int score = 78;
string result = score switch
{
   >= 85 => "Отлично",
   >= 70 => "Хорошо",
   >= 50 => "Удовлетворительно",
   >= 0 => "Неудовлетворительно",
   _ => "Некорректный балл",
};
Console.WriteLine(result);



int temperature = int.Parse(Console.ReadLine());

switch (temperature)
{
   case <= 0:
      Console.WriteLine("Мороз");
      break;
   case >= 0 and <=14:
      Console.WriteLine("Прохладно");
      break;
   case >= 15 and <= 24:
      Console.WriteLine("Комфортно");
      break;
   case >= 25 and <= 34:
      Console.WriteLine("Жарко");
      break;
   case > 35:
      Console.WriteLine("Очень жарко");
      break;
}