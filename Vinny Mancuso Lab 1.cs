namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Name
            string firstName;
            string middleName;
            string lastName;

            System.Console.Write("What Is Your First Name?");
            firstName = System.Console.ReadLine();
            System.Console.Write("What Is Your Middle Name?");
            middleName = System.Console.ReadLine();
            System.Console.Write("What Is Your Last Name?");
            lastName = System.Console.ReadLine();

            string fullName = firstName + " " + middleName + " " + lastName;

            System.Console.WriteLine("Your Full Name Is"+ " " + fullName);

            System.Threading.Thread.Sleep(5000);

            #endregion

            #region Age

            int age;


            System.Console.Write("How Old Are You?");
            age = int.Parse(System.Console.ReadLine());


            #endregion

            #region Height
            
            double inchHeight;
            double totalHeight;
            double feetHeight;
            double centiToFoot;
            double centiToInch;
            double inchConversion;

            centiToFoot = 0.0328084;
            centiToInch = 0.393701;


            System.Console.Write("How Many Feet Tall Are You?");
            feetHeight = double.Parse(System.Console.ReadLine());
            totalHeight = feetHeight / centiToFoot;
            System.Console.Write("How Many Inches Tall Are You?");
            inchHeight = double.Parse(System.Console.ReadLine());
            inchConversion = inchHeight / centiToInch;
            totalHeight += inchConversion;

            System.Console.WriteLine("Your Total Height In Centimeters Is" + " " + totalHeight +".");

            System.Threading.Thread.Sleep(5000);
            #endregion

            #region Citizen Status

            int ageToVote = 18;
            bool citizen;
            System.Console.WriteLine("Are You A US Citizen? True or False?");
            citizen = bool.Parse(System.Console.ReadLine());
            bool canVote = ageToVote < age && citizen;
            System.Console.WriteLine("Your ability to vote is" + " " + canVote);
            System.Threading.Thread.Sleep(5000);

            #region Final Results

            System.Console.WriteLine("Your full name is" + " " + fullName + "." + "Your Height is" + " " + totalHeight + "centimeters" + ".");
            System.Console.WriteLine("Your ability to vote in the US is" + " " + canVote + ".");
            System.Threading.Thread.Sleep(10000);

            #endregion
























            #endregion


        }
    }
}