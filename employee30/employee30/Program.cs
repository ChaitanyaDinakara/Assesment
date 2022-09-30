namespace employee30
{
    internal class Employee
    {
        public delegate void cal(string a,int b);

        public void entry()
        {

            Dictionary<string, string> emp = new Dictionary<string, string>();
            {
                emp.Add("Kevin", "Good");
                emp.Add("David", "Good");
                emp.Add("Harish", "Good");
                emp.Add("Manoj", "bad");
                emp.Add("Priya", "bad");

                foreach (KeyValuePair<string,string> keyValuePair in emp) ;
                Console.WriteLine(KeyValuePair.key.ToString + " " + KeyValuePair.Value);
            }

        }
        public void promotion( string a)
        {
            string keyValue = "Good";
            if(keyValue == "Good")
            Console.WriteLine("promoted");

        }
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.promotion("good");
        }
    }
}