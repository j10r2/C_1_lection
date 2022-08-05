// See https://aka.ms/new-console-template for more information
Console.WriteLine("Кто здесь? о_О");
Console.WriteLine();
string name = Console.ReadLine();

if(name.ToLower() == "маша")
{
    Console.WriteLine();
    Console.WriteLine("Шла бы ты отсюда, Маша...");
}
else
{
    Console.WriteLine();
    Console.Write("Ну привет, ");
    Console.Write(name);
}