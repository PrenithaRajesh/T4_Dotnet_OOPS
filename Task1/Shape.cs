namespace Dotnet_OOPS.Task1
{
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing Shape");
        }

        public static void Fun()
        {
            Console.WriteLine("This is a static function in the parent");
        }
    }
}