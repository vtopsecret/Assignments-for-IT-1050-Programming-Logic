
namespace Lab_2
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;
        public static int Add;
        public static double SumOfAllAges;

        public string GetFullName()
        {
            return this.FirstName + " " + LastName;

        }

        public void PrintNameAndAge()
        {
            System.Console.WriteLine(this.GetFullName());
            System.Console.WriteLine(this.Age);
        }

        public void AskForNameAndAge()
        {
            System.Console.WriteLine("What is your First Name?");
            this.FirstName = System.Console.ReadLine();

            System.Console.WriteLine("What is Your Last Name?");
            this.LastName = System.Console.ReadLine();

            System.Console.WriteLine("What is your Age?");
            this.Age = int.Parse(System.Console.ReadLine());

            Person.Add++;
            Person.SumOfAllAges += this.Age;

        }

        public static double AverageAge()
        {
            return (double)Person.SumOfAllAges / (double)Person.Add;
        }


        public void CreateSpouseIfMarried()
        {
            System.Console.Write("Are you married? (y/n) : ");

            if (System.Console.ReadLine().ToLower().StartsWith("y"))
            {
                this.Spouse = new Person();
                this.Spouse.AskForNameAndAge();
                this.Spouse.Spouse = this;
            }

        


        }
    }
}
