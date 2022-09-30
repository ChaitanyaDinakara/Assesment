using System.Xml.Linq;
using static bird30.abstractclass;

namespace bird30
{
    public class abstractclass
    {
        
        public class Crow : Bird
        {
            public override void Eat()
            {
                Console.WriteLine("eating");
                Console.WriteLine("the bird is about to fly");
            }

            
        }

        public abstract class Bird
        {
            private string Name;

            public void SetName(string name)
            {
                Name = name;
            }

            public string GetName()
            {
                return Name;
            }
           
            public abstract void Eat();
        }

           public static void Main(string[] args)
            {
                Crow c = new Crow();
            Console.WriteLine("enter the name of the crow");
               c.SetName(Console.ReadLine());
                Console.WriteLine(c.GetName());
                c.Eat();
            }

        }
    }

    
