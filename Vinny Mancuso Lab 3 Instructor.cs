namespace ConsoleApp4
{
    class Instructor
    {
        public string iname;
        public string courseName;
        public int thegrade;
       

        public Instructor(string iname, string courseName)
        {
            this.iname = iname;
            this.courseName = courseName;
        }


        public void SetStudentGrade(Student student, int thegrade)
        {
            student.grade += thegrade;
            System.Console.WriteLine("The Instructor has set student " + student.name + " grade to " + thegrade);
        }

        public void Print(Instructor instructor, string courseName)
        {
           System.Console.WriteLine(instructor.iname + " " + courseName);
        }

    }
}
