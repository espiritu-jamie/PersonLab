using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PersonLab
{
    internal class Person
    {
        private int personId;
        private string firstName;
        private string lastName;
        private int age;
        private string favoriteColor;
        private bool isWorking;

        public Person(int personId, string firstName, string lastName, int age, string favoriteColor, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.favoriteColor = favoriteColor;
            this.isWorking = isWorking;
        }

        public string DisplayPersonInfo()
        {
            string firstName = this.firstName;
            string lastName = this.lastName;
            int personId = this.personId;

            string name = firstName + " " + lastName;

            string favoriteColor = this.favoriteColor;

            Console.WriteLine(personId + ": " + name + "'s favorite color is " + favoriteColor);

            return personId + name + favoriteColor;
        }

        public string ChangeFavoriteColor()
        {
            string favoriteColor = this.favoriteColor;
            this.favoriteColor = "White";
            return favoriteColor;
        }

        public int GetAgeInTenYears()
        {
            string firstName = this.firstName;
            string lastName = this.lastName;
            int age = this.age;

            string name = firstName+ " " + lastName;

            int ageInTenYears = age + 10;

            Console.WriteLine(name + "'s Age in 10 years is: " + ageInTenYears);

            return ageInTenYears;
        }

        public override string ToString()
        {
            int personId = this.personId;
            string firstName = this.firstName;
            string lastName = this.lastName;
            int age = this.age;
            string favoriteColor = this.favoriteColor;
            bool isWorking = this.isWorking;

            string name = firstName + " " + lastName;

            Console.WriteLine("PersonId: " + personId + "\nFirstName: " + firstName + "\nLastName: " + lastName
                + "\nFavoriteColor: " + favoriteColor + "\nAge: " + age + "\nIsWorking: " + isWorking);

            return personId + name + favoriteColor + age + isWorking;
        }
    }
}
