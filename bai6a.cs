using System;

class Program
{
    static void Main(string[] args)
    {
        double[] numbers;
        int length;
        double sum = 0;
        double average;

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

        // Tính tổng các phần tử trong mảng
        foreach (double num in numbers)
        {
            sum += num;
        }

        // Tính trung bình cộng
        average = sum / length;

        // In kết quả
        Console.WriteLine($"Trung bình cộng của các phần tử trong mảng là: {average}");
        Console.ReadLine();
    }
}