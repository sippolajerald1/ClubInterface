using System;
namespace ClubInterface
{
    interface IClub
    {
        //Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Methods
        public string Fullname();
    }
    class operations : IClub
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bar { get; set; }
        public int NumberofServers { get; set; }
        public int NumberofBartenders { get; set; }
        public int NumberofBouncers { get; set; }

        public operations()
        {
            Id = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            Bar = string.Empty;
            NumberofServers = 0;
            NumberofBartenders = 0;
            NumberofBouncers = 0;
        }

        public operations(int id, string firstName, string lastName, string bar, int numberofServers, int numberofBartenders, int numberofBouncers)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Bar = bar;
            NumberofServers = numberofServers;
            NumberofBartenders = numberofBartenders;
            NumberofBouncers = numberofBouncers;
        }


        public string Fullname()
        {
            return FirstName + " " + LastName;
        }

        public int TotalNumberofStaff()
        {
            return NumberofServers + NumberofBartenders + NumberofBouncers;
        }



    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            // operations object created using parameterized constructor
            operations Tom = new operations(10, "Tom", "Darcy", "Squirrel Bar", 5, 2, 3);
            Console.WriteLine(Tom.Bar);
            Console.WriteLine(Tom.Fullname());
            Console.WriteLine(Tom.TotalNumberofStaff());
          

            // operations object created using the default constructor
            // values are assigned using properties
            operations Bob = new operations();
            Bob.Id = 15;
            Bob.FirstName = "Bob";
            Bob.LastName = "Smith";
            Bob.Bar = "Stampede Bar";
            Bob.NumberofServers = 10;
            Bob.NumberofBartenders = 5;
            Bob.NumberofBouncers= 2;


            Console.WriteLine(Bob.Bar);
            Console.WriteLine(Bob.Fullname());
            Console.WriteLine(Bob.TotalNumberofStaff());
           
       
        }
    }
}
