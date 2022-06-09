Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "настя")
{
    Console.WriteLine("Привет, зайчик =)");
    Console.WriteLine("Я тут просто хотел похвалиться своими невероятными навыками программирования, так что вот! Эта супер-пупер программа подсказывает явлется ли первое введенное число квадратом второго");
}
else
{
    Console.Write("Привет,");
    Console.WriteLine(username);
    Console.WriteLine("Эта программ выполняет простую функцию: отвечает на вопрос явлется ли первое введенное число квадратом второго");
} 
Console.WriteLine("Введи первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введи второе число");
int number2 = int.Parse(Console.ReadLine());
int square = number2 * number2;
if (square == number1)
    {
    if(username.ToLower() == "настя")
    Console.WriteLine("Умница! Первое число является квадратом второго! И, кстати, петь у тебя получется прекрасно =)");
    else
    Console.WriteLine("Первое число является квадратом второго");
    }

else
    {
    if(username.ToLower() == "настя")
    Console.WriteLine("Умница! Первое число НЕ является квадратом второго. И, кстати, петь у тебя получется прекрасно =)");
    else
    Console.WriteLine("Первое число НЕ является квадратом второго");
    }