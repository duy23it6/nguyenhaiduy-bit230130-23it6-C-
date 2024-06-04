using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; //
        // Nhập số phần tử của mảng
        int n;
        while (true)
        {
            try
            {
                Console.Write("Nhập số phần tử của mảng: ");
                n = int.Parse(Console.ReadLine());
                if (n > 0)
                    break;
                else
                    Console.WriteLine("Số phần tử phải là số nguyên dương. Vui lòng nhập lại.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại.");
            }
        }

        // Tạo mảng và nhập giá trị
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                try
                {
                    Console.Write($"Nhập phần tử thứ {i + 1} (4 byte): ");
                    arr[i] = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại.");
                }
            }
        }

        // Tính tổng
        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }

        // In kết quả
        Console.WriteLine("Tổng các phần tử trong mảng: " + sum);

        Console.ReadLine();
    }
}