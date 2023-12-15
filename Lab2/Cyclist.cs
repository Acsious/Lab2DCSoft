using System.Text;

namespace Lab2;

internal class Cyclist : IWalker
{
    public async void InjuredAsync()
    {
        using FileStream fstream = new FileStream("CyclistOutput.txt", FileMode.OpenOrCreate);
        // преобразуем строку в байты
        byte[] buffer = Encoding.Default.GetBytes("Велосепидист получил повреждения");
        // запись массива байтов в файл
        await fstream.WriteAsync(buffer);
        Console.WriteLine("Текст записан в файл");
    }
}