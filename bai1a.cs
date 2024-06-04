using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; //
        int a, b;

        // Nhập a
        while (true)
        {
            try
            {
                Console.Write("Nhập số a (4 byte): ");
                a = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại.");
            }
        }

        // Nhập b
        while (true)
        {
            try
            {
                Console.Write("Nhập số b (4 byte): ");
                b = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại.");
            }
        }

        // Tính toán
        int tong = a + b;
        int hieu = a - b;
        int tich = a * b;
        int thuong = a / b;
        float thuongThuc = (float)a / b;

        // In kết quả
        Console.WriteLine("Tổng của a và b: " + tong);
        Console.WriteLine("Hiệu của a và b: " + hieu);
        Console.WriteLine("Tích của a và b: " + tich);
        Console.WriteLine("Thương của a và b (số nguyên): " + thuong);
        Console.WriteLine("Thương của a và b (số thực): " + thuongThuc);

        Console.ReadLine();
    }
}