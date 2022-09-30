namespace Oueue30
{
    internal class Person
    {

        public static void Main(string[] args)
        {
            Queue q = new Queue();
            int total = 5;

            for (int i = 0; i < total; i++)
            {


                string name = Console.ReadLine();
                Console.WriteLine(name);
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine(age);

                q.Enqueue(new Person() { Name = name, Age = age });
            }

            for (int i = 0; i < total; i++)
            {
                Person p = (Person)q.Dequeue();
                Console.WriteLine(p.ToString());
            }
        }
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                return Name + "  " + Age;
            }
        }
    }
}


