using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AlgorithmProblems
{
    class UserDetails
    {
        //properties
        private string firstName;
        private string lastName;
        private long phoneNumber;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public long PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }
        /// <summary>
        /// Display choice method
        /// </summary>
        /// <param name="inp"></param>
        public void UserChoice(char inp)
        {
            inp = Uppercase(inp);
            switch (inp)
            {
                case 'Y':
                    //ask UserDetails//
                    Details();
                    break;
                case 'N':
                    Console.WriteLine("Exiting....");
                    break;
                default:
                    Console.WriteLine("invalid input, try again!!");
                    inp = Convert.ToChar(Console.ReadLine());
                    UserChoice(inp);
                    break;
            }
        }
        /// <summary>
        /// convert to Upper case
        /// </summary>
        /// <param name="ch"></param>
        /// <returns></returns>
        internal char Uppercase(char ch)
        {
            char input = Char.ToUpper(ch);
            return input;
        }
        /// <summary>
        /// Alter user details
        /// </summary>
        internal void Details()
        {
            Console.WriteLine("Enter FirstName: ");
            FirstName = Console.ReadLine();
            if (ValidateName(FirstName))
            {
                Console.WriteLine("First name saved successfully!!");
            }
            else
            {
                Console.WriteLine("Invalid name format");
            }
            Console.WriteLine("Enter lastName: ");
            LastName = Console.ReadLine();
            if (ValidateName(LastName))
            {
                Console.WriteLine("Last name saved successfully!!");
            }
            else
            {
                Console.WriteLine("Invalid name format");
            }
            Console.WriteLine("Enter phone Number");
            string strPhoneNumber = Console.ReadLine();
            if (ValidatePhoneNumber(strPhoneNumber))
            {
                PhoneNumber = Convert.ToInt64(strPhoneNumber);
                Console.WriteLine("Phone Number saved successfully!!");
            }
            else
            {
                Console.WriteLine("invalid Number or format");
            }
            string words = $"Hello {FirstName},\nWe have your fullname as {FirstName + " " + LastName} in our system. \nYour contact number is {PhoneNumber}. Please,let us know in case of any clarification \nThank you BridgeLabz {DateTime.Today}.";
            Console.WriteLine(words);
        }
        /// <summary>
        /// validate Name using Regex
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        internal bool ValidateName(string name)
        {
            string nameRegex = "^[A-Z][a-z]{3,20}$";
            if (Regex.IsMatch(name, nameRegex))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Validate phone number using regex
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        internal bool ValidatePhoneNumber(string phoneNumber)
        {
            string phonenumRegex = "^[6-9][0-9]{9,12}$";
            if (Regex.IsMatch(phoneNumber, phonenumRegex))
            {
                return true;
            }
            return false;
        }
    }
}
