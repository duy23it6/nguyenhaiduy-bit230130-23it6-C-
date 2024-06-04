using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; //
        short[] arr;
        short sum = 0;
        int n;

        // Nhập kích thước mảng
        while (true)
        {
            try
            {
                Console.Write("Nhập kích thước mảng (số nguyên có dấu 2 byte): ");
                n = int.Parse(Console.ReadLine());
                if (n > 0)
                    break;
                else
                    Console.WriteLine("Kích thước mảng phải là số dương. Vui lòng nhập lại.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại.");
            }
        }

        // Nhập các phần tử mảng
        arr = new short[n];
        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                try
                {
                    Console.Write($"Nhập phần tử thứ {i + 1}: ");
                    arr[i] = short.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại.");
                }
            }
        }

        // Tính tổng các phần tử trong mảng
        foreach (short x in arr)
            sum += x;

        // In kết quả lên màn hình
        Console.WriteLine($"Tổng của các số trong mảng là: {sum}");

        Console.ReadLine();
    }
}