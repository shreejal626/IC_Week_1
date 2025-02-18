
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public static class ShapeColourHelper
    {
        private static string[] Colors = { "Yellow", "Red", "Blue", "Green", "Orange" };
        private static Random random = new Random();

        public static Shape AddColour(Shape s)
        {
            s.Colour = "Red";

            return s;
        }

        public static Shape ChangeColour(Shape s)
        {
            s.Colour = "Blue";

            return s;
        }

        public static Shape MakeRandomColour(Shape s)
        {
            s.Colour = Colors[random.Next(Colors.Length)];
            return s;
        }

    }
}
