using System.Threading;

namespace task30
{
    internal class Program
    {
        public void flowerdecor()
        {
            Console.WriteLine("complete the decoration");
            Thread.Sleep(3000);
        }
        public void chiefguest()
        {
            Console.WriteLine("picked the guest from airport");
            Thread.Sleep(2000);
            
        }

        public void coordinate()
        {
            Console.WriteLine("set up the food");
        }

        public void gifts()
        {
            Console.WriteLine("Arrange the gifts");
            Thread.Sleep(3000);
        }
        static async Task start()
        {
             Console.WriteLine("start the function");
            
        }

        static async Task Main(string[] args)
        {
            Program p =new Program();
            
            p.flowerdecor();
            p.chiefguest();
            p.coordinate();
            p.gifts();
            await start();
        }
    }
}