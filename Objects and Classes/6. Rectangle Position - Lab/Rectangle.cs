namespace _6.Rectangle_Position___Lab
{
    public class Rectangle
    {
        public double left { get; set; }

        public double top { get; set; }

        public double width { get; set; }

        public double height { get; set; }

        public double bottom => top - height;

        public double right => width + left;
    }
}
