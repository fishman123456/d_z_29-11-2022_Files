// Создать программу которая выводит информацию о файлах в +
// указанной директории (имя и размер), используя DyrectoryInfo. +
// Создать метод который создает файл, если такой файл уже существует, 
// то сообщает что он есть. Создать метод, который считвыает 
// инфомацию из файла и выводит её на экран.
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
        WriteLine("\nДанные записаны!");
    }
}
}
catch (Exception)
{

    throw;
}
// в каталоге
foreach (FileInfo f in files)
{
    WriteLine(f.Name + ":\t\t\t" + "\t" + f.Length);
}
WriteLine("------------------------------------------");
