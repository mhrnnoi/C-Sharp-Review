using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EmergenceService
{
    public class User
    {
        public string Id { get; private set; }
        public string Address { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Gender { get; private set; }


        public User()
        {
            FormFilling();

        }
        public void FormFilling()
        {
            this.Address = FillAddress();
            this.FirstName = FillFirstName();
            this.LastName = FillLastName();
            this.Id = FillId();
            this.Gender = FillGender();







        }



        public static string FillGender()
        {
            string input;

            do
            {
                Console.WriteLine("select your gender: female (f) male (m) ");
                input = Console.ReadLine().ToLower();
                if (input != "m" && input != "f")
                {
                    Console.WriteLine("not ok -> entered input incorrect");
                    Console.WriteLine("plz enter f/m ..");

                }
                else
                    return input;
            } while (true);










        }
        public static string FillAddress()
        {
            string input;

            do
            {
                Console.WriteLine("Enter your address: ");
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("not ok -> address  cannot be null ");

                }
                else if (input.Count(a => char.IsLetter(a) == true) < 2)
                {
                    Console.WriteLine("not ok ->  plz enter valid address");

                }
                else
                    return input;

            } while (true);



        }
        public static string FillFirstName()
        {
            string input;
            do
            {
                Console.WriteLine("Enter your first name: ");
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("not ok first name or last name  cannot be null ");

                }
                else if (input.Count(a => char.IsNumber(a) == true) > 0)
                {
                    Console.WriteLine("not ok plz enter valid  Name ");

                }
                else if (input.Count(a => (a) == ' ') > 0)
                {
                    Console.WriteLine("not ok first name or last name cannot have white space");

                }
                else
                {
                    return input;

                }
            } while (true);





        }
        public static string FillLastName()
        {
            string input;
            do
            {
                Console.WriteLine("Enter your Last name: ");
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("not ok first name or last name  cannot be null ");

                }
                else if (input.Count(a => char.IsNumber(a) == true) > 0)
                {
                    Console.WriteLine("not ok plz enter valid  Name ");

                }
                else if (input.Count(a => (a) == ' ') > 0)
                {
                    Console.WriteLine("not ok first name or last name cannot have white space");

                }
                else
                {
                    return input;

                }
            } while (true);





        }






        public static string FillId()
        {
            string input;
            do
            {
                Console.WriteLine("Enter your id: ");
                input = Console.ReadLine();
                if (input.Length < 8)
                {
                    Console.WriteLine("not ok id must be at least 8 numbers ");
                }
                else if (input.Count(a => char.IsNumber(a) == true) != input.Length)
                {
                    Console.WriteLine("not ok plz enter valid id ");
                }
                else
                {
                    return input;
                }
            } while (true);


        }
        
        


    }

}
