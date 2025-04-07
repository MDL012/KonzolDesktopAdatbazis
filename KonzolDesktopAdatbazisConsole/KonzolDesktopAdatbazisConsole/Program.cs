// See https://aka.ms/new-console-template for more information
using KonzolDesktopAdatbazisConsole.DBModel;
using KonzolDesktopAdatbazisConsole.Model;
using KonzolDesktopAdatbazisConsole.Repo;

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

Console.WriteLine("2. feladat");
WorkerApplicant janos = new WorkerApplicant("janos@ceg.hu", "Dolgozó János");
Console.WriteLine(janos);

Console.WriteLine("3. feladat");
try
{
    janos.AddMoney(-300000);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("4. feladat");
janos.AddMoney(200000);
janos.AddMoney(300000);
Console.WriteLine(janos);

WorkerRepo repo = new WorkerRepo();
Console.WriteLine($"Dolgozók száma: {repo.GetNumberOfWorker()}");
