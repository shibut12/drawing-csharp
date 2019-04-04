using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace drawing_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Bitmap bmp = new Bitmap(600, 400))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.FillRectangle(Brushes.Green, 0, 0, 600, 400);
                }
                bmp.Save("test-image.png", ImageFormat.Png);
            }
            Console.WriteLine($"A new image file is created at {System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)}\\test-image.png");
            Console.ReadKey();
        }
    }
}
