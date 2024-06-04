using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; //
        byte n;
        byte sum = 0;

        // Nhập số nguyên n
        while (true)
        {
            try
            {
                Console.Write("Nhập số nguyên không dấu (1 byte): ");
                n = byte.Parse(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại.");
            }
        }

        // Tính tổng các chữ số trong n
        while (n > 0)
        {
            sum += (byte)(n % 10);
            n /= 10;
        }

        // In kết quả lên màn hình
        Console.WriteLine($"Tổng của các chữ số là: {sum}");

        Console.ReadLine();
    }
}