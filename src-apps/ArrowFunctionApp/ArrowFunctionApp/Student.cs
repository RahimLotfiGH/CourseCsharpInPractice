namespace ArrowFunctionApp
{
    public class Student
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => FirstName + " " + LastName;


    }
}
