using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; //
        sbyte[] numbers;
        int numCount;
        int evenSum = 0;

        // Nhập số lượng phần tử trong dãy số
        while (true)
        {
            try
            {
                Console.Write("Nhập số lượng phần tử trong dãy số: ");
                numCount = int.Parse(Console.ReadLine());
                if (numCount > 0)
                    break;
                else
                    Console.WriteLine("Số lượng phần tử phải lớn hơn 0. Vui lòng nhập lại.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại.");
            }
        }

        // Nhập các phần tử trong dãy số
        numbers = new sbyte[numCount];
        for (int i = 0; i < numCount; i++)
        {
            while (true)
            {
                try
                {
                    Console.Write($"Nhập phần tử thứ {i + 1}: ");
                    numbers[i] = sbyte.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại.");
                }
            }
        }

        // Tính tổng các số chẵn trong dãy số
        for (int i = 0; i < numCount; i++)
        {
            if (numbers[i] % 2 == 0)
                evenSum += numbers[i];
        }

        // In kết quả lên màn hình
        Console.WriteLine($"Tổng các số chẵn trong dãy số: {evenSum}");

        Console.ReadLine();
    }
}