// See https://aka.ms/new-console-template for more information
using KonzolDesktopAdatbazisConsole.DBModel;
using KonzolDesktopAdatbazisConsole.Model;

Console.WriteLine("Hello, World!");

Console.WriteLine("1. feladat");

try
{
    WorkerApplicant empty = new WorkerApplicant("", "Null");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
