namespace file30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the name");
            string name= Console.ReadLine();
            StreamWriter sw = new StreamWriter("C:\\Users\\chaitanya.dinakara\\OneDrive - Entain Group\\Documents\\ name.txt");
            sw.WriteLine("This is Chaitanya");
            sw.WriteLine("My age is 22");
            sw.WriteLine("I love dancing");
            sw.WriteLine("I love glass painting");
            sw.WriteLine("I am hyped about learning new things");
            sw.WriteLine("make everyone happy");
            sw.WriteLine("enjoy your day");
            sw.WriteLine("Have fun");
            sw.WriteLine("Knowledge is power");
            sw.WriteLine("have a great day");
        }
    }
}