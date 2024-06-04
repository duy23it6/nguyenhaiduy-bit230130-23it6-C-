using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; //
        long[] numbers;
        int length;

        // Nhập kích thước mảng
        while (true)
        {
            try
            {
                Console.Write("Nhập kích thước mảng: ");
                length = int.Parse(Console.ReadLine());
                if (length > 0)
                    break;
                else
                    Console.WriteLine("Kích thước mảng phải lớn hơn 0. Vui lòng nhập lại.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại.");
            }
        }

        // Nhập các phần tử của mảng
        numbers = new long[length];
        for (int i = 0; i < length; i++)
        {
            while (true)
            {
                try
                {
                    Console.Write($"Nhập phần tử thứ {i + 1}: ");
                    numbers[i] = long.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại.");
                }
            }
        }

        // Tính tổng các phần tử trong mảng
        long sum = 0;
        foreach (long num in numbers)
        {
            sum += num;
        }

        // In kết quả
        Console.WriteLine($"Tổng các phần tử trong mảng là: {sum}");
        Console.ReadLine();
    }
}