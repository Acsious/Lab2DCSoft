using System.Text;

namespace Lab2;

internal class Car : ITransport
{
    public async void CrushedAsync()
    {
        using FileStream fstream = new FileStream("CarOutput.txt", FileMode.OpenOrCreate);
        // преобразуем строку в байты
        byte[] buffer = Encoding.Default.GetBytes("Автомобиль получил повреждения");
        // запись массива байтов в файл
        await fstream.WriteAsync(buffer);
        Console.WriteLine("Текст записан в файл");
    }
}
