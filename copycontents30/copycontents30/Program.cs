namespace copycontents30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("C:\\Users\\chaitanya.dinakara\\OneDrive - Entain Group\\Documents\\file.txt",FileMode.OpenOrCreate);
            fs.Close();
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Today is Friday\n", "have a nice day");
            sw.Close();
            FileStream fs1 = new FileStream("C:\\Users\\chaitanya.dinakara\\OneDrive - Entain Group\\Documents\\file1.txt", FileMode.OpenOrCreate);
            StreamWriter sw2 = new StreamWriter(fs1);
            sw2.WriteLine("Today is Thursday\n", "Enjoy ur day");
            sw2.Close();
            fs1.CopyTo(fs);
            fs.Close();
            fs1.Close();

        }
    }
}