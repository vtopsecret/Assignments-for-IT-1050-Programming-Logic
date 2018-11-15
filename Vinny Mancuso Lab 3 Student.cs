namespace ConsoleApp4
{
    class Student
    {
        public string name;
        public int grade;
        public Student Instructor;
       

        public Student(string name, int grade, Instructor instructor)
        {
            this.name = name;
            this.grade = grade;
        }

        public void Print(Instructor instructor)
        {
            System.Console.WriteLine("The student " + name + " has a grade of  " + grade + ". Their teacher is " + instructor.iname + ".");
        }


    }

}
