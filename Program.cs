// // int number = int.Parse(Console.ReadLine()!);

// // switch(number)
// // {
// //    case 1: Console.WriteLine("Начало");
// //       break;
// //    case 2: Console.WriteLine("Середина");
// //       break;
// //    default: Console.WriteLine("Другое значение");
// //       break;
// // }


// // int day = int.Parse(Console.ReadLine());
// // switch (day)
// // {
// //    case 6 or 7: Console.WriteLine("Выходной");
// //       break;
// //    default:
// //       Console.WriteLine("Будний");
// //       break;
// // }




// // using System.Collections;

// // int temperature = int.Parse(Console.ReadLine());

// // switch (temperature)
// // {
// //    case <= 0:
// //       Console.WriteLine("");
// // }



// // using System.Reflection.Metadata;

// // int score = 50;
// // string result = score switch
// // {
// //    >= 91 => "Отлично",
// //    >= 71 => "Хорошо",
// //    >= 51 => "Удовлетворительно",
// //    _ => "Неудовлетворительно",
// // };
// // Console.WriteLine(result);



// // string role = Console.ReadLine()!;
// // switch (role)
// // {
// //    case "admin":
// //       Console.WriteLine("Полный доступ");
// //       break
// // }



// // int age = int.Parse(Console.ReadLine());
// // bool hasTicket = true;
// // switch (age)
// // {
// //    case >= 18 when hasTicket:
// //       Console.WriteLine("Вход разрешен");
// //       break;
// //    case <= 18:
// //       Console.WriteLine("У вас нет билета");
// //       break;
// //    default:
// //       Console.WriteLine("Вход запрещен");
// //       break
// // }



// // switch (number)
// // {
// //    case 1: Console.WriteLine("Начало");
// //       break;
// //    case 2: Console.WriteLine("Середина");
// //       break;
// //    default: Console.WriteLine("Другое значение");
// //       break;
// // }






// int day = int.Parse(Console.ReadLine());
// switch (day)
// {
//    case 6 or 7 or 5:
//       Console.WriteLine("Выходной");
//       break;
//    default:
//       Console.WriteLine("Будний");
//       break;
// }





// int score = 78;
// switch(score)
// {
//    case >= 0 and < 39:
//       Console.WriteLine("Неудовлетворительно");
//       break;
//    case >= 40 and < 59:
//       Console.WriteLine("Удовлетворительно");
//       break;
//    case >= 60 and < 79:
//       Console.WriteLine("Хорошо");
//       break;
//    case >= 80 and <= 100:
//       Console.WriteLine("Отлично");
//       break;
//    default:
//    Console.WriteLine("Некорректный балл");
// break;

// };



// int score = 78;
// string result = score switch
// {
//    >= 85 => "Отлично",
//    >= 70 => "Хорошо",
//    >= 50 => "Удовлетворительно",
//    >= 0 => "Неудовлетворительно",
//    _ => "Некорректный балл",
// };
// Console.WriteLine(result);



int temperature = int.Parse(Console.ReadLine());

switch (temperature)
{
   case <= 0:
      Console.WriteLine("Мороз");
      break;
   case >= 0 and <= 14:
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



// string role = "user";

// string result = role switch
// {
//    "teacher" => "Доступ преподавателя",
//    not "teacher" and not "user" => "Ограниченный доступ"
// };

// Console.WriteLine(result);



// int age = 20;
// bool hasTicket = true;
// switch (age)
// {
//    case >= 18 when hasTicket:
//       Console.WriteLine("Вход разрешен");
//       break;
//    case >= 18:
//       Console.WriteLine("Нет билета");
//       break;
//    default:
//       Console.WriteLine("Возраст не подходит");
//       break;
// }




// int level = 2;

// switch (level)
// {
//    case 1:
//       Console.WriteLine("Начальный уровень");
//       break;
//    case 2:
//       Console.WriteLine("Средний уровень");
//       goto case 1;
//    case 3:
//       Console.WriteLine("Продвинутый уровень");
//       break;
// }



// //Задача А
// int month = int.Parse(Console.ReadLine());
// switch (month)
// {
//    case 12 or 1 or 2:
//       Console.WriteLine("Зима");
//       break;
//    case 3 or 4 or 5:
//       Console.WriteLine("Весна");
//       break;
//    case 6 or 7 or 8:
//       Console.WriteLine("Лето");
//       break;
//    case 9 or 10 or 11:
//       Console.WriteLine("Осень");
//       break;
//    default:
//       Console.WriteLine("Неверный месяц");
//       break;
// }


//Задача Б
// int age = int.Parse(Console.ReadLine());

// switch (age)
// {
//    case <= 0:
//       Console.WriteLine("Ошибка");
//       break;
//    case > 0 and <= 6:
//       Console.WriteLine("Ребенок");
//       break;
//    case >= 7 and <= 17:
//       Console.WriteLine("Подросток");
//       break;
//    case >= 18 and <= 64:
//       Console.WriteLine("Взрослый");
//       break;
//    case > 65:
//       Console.WriteLine("Пенсионер");
//       break;
// }


// //Индувидуальный вариант 2, 8

// int score = int.Parse(Console.ReadLine());
// switch (score)
// {
//    case >= 0 and <= 39:
//       Console.WriteLine("Неудовлетворительно");
//       break;
//    case >= 40 and <= 59:
//       Console.WriteLine("Удовлетворительно");
//       break;
//    case >= 60 and <= 79:
//       Console.WriteLine("Хорошо");
//       break;
//    case >= 80 and <= 100:
//       Console.WriteLine("Отлично");
//       break;
//    default:
//       Console.WriteLine("Ошибка");
//       break;

// }


// string role1 = "автобус";

// string result = role1 switch
// {
//    "автобус" => "Наземный транспорт",
//    "метро" => "Подземный транспорт",
//    "такси" => "Индивидуальный транспорт",
//    _ => "Неизвестный транспорт"

// };

// Console.WriteLine(result);


