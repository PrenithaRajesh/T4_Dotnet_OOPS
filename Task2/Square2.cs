namespace Dotnet_OOPS.Task2
{
    public class Square2 : IShape
    {
        public float CalculateArea(float side)
        {
            return side * side;
        }

        public float CalculatePerimeter(float side)
        {
            return 4 * side;
        }
    }
}