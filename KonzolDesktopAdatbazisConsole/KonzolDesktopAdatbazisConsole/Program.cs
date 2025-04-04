// See https://aka.ms/new-console-template for more information
using KonzolDesktopAdatbazisConsole.DBModel;

Console.WriteLine("Hello, World!");

Console.WriteLine("1. feladat");

try
{
    Worker empty = new Worker("", "Null");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
