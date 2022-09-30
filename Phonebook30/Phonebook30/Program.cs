using System.Globalization;

namespace Phonebook30
{
    internal class Phonebook
    {
        class Student : Phonebook
        {

            void display()
            {
                List<string> ItemList = new List<string>();
                List<int> Items = new List<int>();
                List<string> item = new List<string>();
                Console.WriteLine("enter the items to be added");
                for (int i = 0; i < 10; i++)
                {
                    ItemList.Add(i.ToString());
                   
                }

                for (int j = 0; j < 10; j++)
                {
                    Items.Add(j);
                }
                for (int k = 0; k < 10; k++)
                {
                    item.Add(k.ToString());
                }
            }

                static void Main(string[] args)
                {
                 Student s = new Student();
                    s.display();
                }
            }
        }
    }


            
        
    
