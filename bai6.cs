using System;

class Program
{
    static void Main(string[] args)
    {
        double[] numbers;
        int length;
        double max, min;

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
        numbers = new double[length];
        for (int i = 0; i < length; i++)
        {
            while (true)
            {
                try
                {
                    Console.Write($"Nhập phần tử thứ {i + 1}: ");
                    numbers[i] = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại.");
                }
            }
        }

        // Tìm giá trị lớn nhất và nhỏ nhất
        max = numbers[0];
        min = numbers[0];
        for (int i = 1; i < length; i++)
        {
            if (numbers[i] > max)
                max = numbers[i];
            if (numbers[i] < min)
                min = numbers[i];
        }

        // In kết quả
        Console.WriteLine($"Giá trị lớn nhất: {max}");
        Console.WriteLine($"Giá trị nhỏ nhất: {min}");
        Console.ReadLine();
    }
}