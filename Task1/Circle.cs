namespace Dotnet_OOPS.Task1{
    public class Circle : Shape{
        public override void Draw(){
            Console.WriteLine("Drawing Circle");
        }

        // Overloading
        public void Draw(int radius){
            Console.WriteLine("Drawing Circle with radius " + radius);
        }
    }
}