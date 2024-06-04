using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; //
        byte n;
        uint sum = 0;

        // Nhập số nguyên n
        while (true)
        {
            try
            {
                Console.Write("Nhập số nguyên n (không dấu, 1 byte): ");
                n = byte.Parse(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại.");
            }
        }

        // Tính tổng các số từ 1 đến n
        for (byte i = 1; i <= n; i++)
        {
            sum += i;
        }

        // In kết quả lên màn hình
        Console.WriteLine($"Tổng của các số từ 1 đến {n} là: {sum}");

        Console.ReadLine();
    }
}
