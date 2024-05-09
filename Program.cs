namespace Assignment_1._4
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            Point p2 = new Point();
            if (p1.x == p2.x)
            {
                Console.WriteLine("Points are on the same axis.");
            }
            else
            {
                Console.WriteLine("Points are not on the same axis.");
            }
            
        }
        public struct Point
        {
           public double x;
           public double y;


        }
    }
}
