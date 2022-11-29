// Создать программу которая выводит информацию о файлах в +
// указанной директории (имя и размер), используя DyrectoryInfo. +
// Создать метод который создает файл, если такой файл уже существует, 
// то сообщает что он есть. Создать метод, который считвыает 
// инфомацию из файла и выводит её на экран.
using static System.Console;

// текущий каталог
DirectoryInfo dir = new DirectoryInfo(".");
WriteLine($"Full path to thedirectory:\n{ dir.FullName}");
WriteLine($"Time of creation:{ dir.CreationTime}");
WriteLine("\n\tAll directory files:");
FileInfo[] files = dir.GetFiles(); // все файлы
// в каталоге
foreach (FileInfo f in files)
{
    WriteLine(f.Directory + "    " + f.Name + ":\t\t\t" + "\t"+f.Length);
    
}
WriteLine();

StreamWriter sw = null;
try
{
    sw = new StreamWriter("file.txt");

    for (int i = 0; i < 2; ++i)
        sw.Write(i + "  Hello world!\n");
}
catch (Exception ex)
{
    Console.WriteLine("Output stream error");
}
finally
{
    if (sw != null) sw.Close();
}