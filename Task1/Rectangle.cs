namespace Dotnet_OOPS.Task1{
    public class Rectangle : Shape{
        public override void Draw(){
            Console.WriteLine("Drawing Rectangle");
        }

        // Hiding
        public static new void Fun(){
            Console.WriteLine("This is a static function in the child");
        }
    }
}