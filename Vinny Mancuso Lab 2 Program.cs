namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();

            p1.AskForNameAndAge();
            p1.CreateSpouseIfMarried();

            p2.AskForNameAndAge();
            p2.CreateSpouseIfMarried();

            System.Console.WriteLine("Average Age: " + Person.AverageAge());
            System.Threading.Thread.Sleep(5000);

            p1.PrintNameAndAge();
            p1.Spouse.PrintNameAndAge();
            p2.PrintNameAndAge();
            p2.Spouse.PrintNameAndAge();
            System.Threading.Thread.Sleep(10000);


        }
    }
}
