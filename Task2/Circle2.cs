namespace Dotnet_OOPS.Task2
{
    public class Circle2 : IShape
    {
        public float CalculateArea(float radius)
        {
            return 3.14f * radius * radius;
        }

        public float CalculatePerimeter(float radius)
        {
            return 2 * 3.14f * radius;
        }
    }
}