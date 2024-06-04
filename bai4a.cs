using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; //

        ulong num;

        // Nhập số nguyên không dấu 8 byte
        while (true)
        {
            try
            {
                Console.Write("Nhập số nguyên không dấu 8 byte: ");
                num = ulong.Parse(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại.");
            }
        }

        // Kiểm tra xem số đó có phải là số Palindrome hay không
        ulong originalNum = num;
        ulong reversedNum = 0;
        while (num > 0)
        {
            reversedNum = reversedNum * 10 + (num % 10);
            num /= 10;
        }

        if (originalNum == reversedNum)
            Console.WriteLine($"{originalNum} là số Palindrome.");
        else
            Console.WriteLine($"{originalNum} không phải là số Palindrome.");

        Console.ReadLine();
    }
}