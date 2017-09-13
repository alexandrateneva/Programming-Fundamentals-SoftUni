namespace _08.Refactor_Volume_of_Pyramid___Lab
{
    using System;

    public class RefactorVolumeOfPyramid
    {
        public static void Main()
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Pyramid Volume: {0:F2}", (length * width * height) / 3);
        }
    }
}
