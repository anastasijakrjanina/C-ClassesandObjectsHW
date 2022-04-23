namespace ClassAndObjectHW
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Year { get; set; }
        public string Hobby { get; set; }
        public string Gender { get; set; }


        public void PersonGreeting()
        {
            Console.WriteLine($"Hello {FirstName} {LastName}!");
        }

        public void PersonAge()
        {
            int age = 2022 - Year;
            Console.WriteLine($"Your current age is {age}");
        }
    }
}
