using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace TrimApp
{
    class Program
    {

        static string str = "@";
        static string save;
        static int point;
        static void Main(string[] args)
        {
            string[] files = Environment.GetCommandLineArgs();
            Console.WriteLine(files[0]);
            save = files[0];
            point = save.LastIndexOf("/") + 1;
            
            for (int i = 0; i < files.Length; i++)
            {
                files[i] = str + files[i];
                Bitmap png = new Bitmap(files[i]);

                Rectangle rect = new Rectangle(0, 80, 2560, 1440);
                Bitmap npng = png.Clone(rect, png.PixelFormat);

                string newpath = files[i].Remove(point) + "trim";
                npng.Save(newpath, ImageFormat.Png);

                npng.Dispose();
                png.Dispose();
            }

        }
    }
}
