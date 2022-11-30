// Создать программу которая выводит информацию о файлах в +
// указанной директории (имя и размер), используя DyrectoryInfo. +
// Создать метод который создает файл, если такой файл уже существует, 
// то сообщает что он есть. Создать метод, который считвыает 
// инфомацию из файла и выводит её на экран.
using System.Runtime.CompilerServices;
using System.Text;

using static System.Console;

// текущий каталог
DirectoryInfo dir = new DirectoryInfo(".");
WriteLine($"Full path to thedirectory:\n{ dir.FullName}");
WriteLine($"Time of creation:{ dir.CreationTime}");
WriteLine("\n\tAll directory files:");
FileInfo[] files = dir.GetFiles(); // все файлы

try
{


string filePath = "test.txt";
using (FileStream fs = new FileStream(filePath, FileMode.CreateNew))
{
        
        using (StreamWriter sw = new StreamWriter(fs,Encoding.Unicode))

    {
        WriteLine("Введите что записываем");
        string writeText = ReadLine();
        // записываем данные в файл
        sw.WriteLine(writeText);
        foreach (var item in writeText)
        {
            sw.Write($"{item}");
        }
        WriteLine("Данные записаны!\n");
    }
}
}
catch (IOException у)
{
    WriteLine("\nФайл существует!!!\n");
    WriteLine(у.Message+"\n");
    WriteLine("--------------------------------------");
    WriteLine("Вывод содержимого файла \"test.txt\"");
    FilePrint();
    WriteLine("--------------------------------------");
}
finally
{

}
// в каталоге
foreach (FileInfo f in files)
{
    WriteLine(f.Name + ":\t\t\t" + "\t" + f.Length);
}
WriteLine("------------------------------------------");
static void FilePrint()
{
    string[] lines = File.ReadAllLines("test.txt"); //Читаем все строки из файла names.txt в массив строк lines
    foreach (var line in lines) //Перебираем все элементы массива lines. Для каждого значения будет вызываться код, находящийся ниже
        Console.WriteLine(line); //Собственно выводим в консоль строку
}
