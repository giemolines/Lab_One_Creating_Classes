using System;
using lab_one_creating_classes;
using System.Linq;

namespace lab_one_creating_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create Person objects
            Person person1 = new Person(1, "Ian", "Brooks", 30, "Red", true);
            Person person2 = new Person(2, "Gina", "James", 18, "Green", false);
            Person person3 = new Person(3, "Mike", "Briscoe", 45, "Blue", true);
            Person person4 = new Person(4, "Mary", "Beals", 28, "Yellow", true);

            // Create and populate list of people
            List<Person> people = new List<Person>();

            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);

            // Display Gina's information
            string ginasInfo = person2.DisplayPersonInfo();
            Console.WriteLine(ginasInfo);

            // Display Mike's information
            string mikesInfo = person3.ToString();
            Console.WriteLine(mikesInfo);

            // Change Ian's favorite color to white
            person1.ChangeFavoriteColour();
            // Displaying Ian's Information
            string iansInfo = person1.DisplayPersonInfo();
            Console.WriteLine(iansInfo);

            // Display Mary's age in 10 years
            int marysAgeTenYears = person4.GetAgeInTenYears();
            Console.WriteLine($"{person4.FirstName} {person4.LastName}'s age in 10 years is: {marysAgeTenYears}");

            // Create Relation instances (linking Person instances together)
            Relation relation1 = new Relation("Sister", person2, "Sister", person4);
            Relation relation2 = new Relation("Brother", person1, "Brother", person3);

            // Display first relation
            Console.WriteLine($"Relationship between {person2.FirstName} and {person4.FirstName} is: {relation1.ToString()}");

            // Display second relation
            Console.WriteLine($"Relationship between {person1.FirstName} and {person3.FirstName} is: {relation2.ToString()}");

            // Determine average age
            int sum = 0;

            // Get sum of everyone's age
            foreach (Person person in people)
            {
                sum += person.Age;
            }

            // Create a list to store ages
            List<int> ages = new List<int>();

            // Loop through people and add their ages to the ages list
            foreach (Person person in people)
            {
                ages.Add(person.Age);
            }

            // Divide sum by number of people.
            // One operand for / operator must be double for result to be double.
            double average = sum / (double)people.Count;

            // Display average age
            Console.WriteLine("Average age is: " + average);

            //Display the youngest person

            // Use an int method to get lowest age value
            int lowestAge = ages.Min();

            // Loop through people and find the youngest person
            foreach (Person person in people)
            {
                if (person.Age == lowestAge)
                {
                    Console.WriteLine($"The youngest person is: {person.FirstName}");
                }
            }

            //Display the oldest person

            // Use an int method to get lowest age value
            int oldestAge = ages.Max();

            // Loop through people and find the oldest person
            foreach (Person person in people)
            {
                if (person.Age == oldestAge)
                {
                    Console.WriteLine($"The oldest person is: {person.FirstName}");
                }
            }

            // Print the information of the people whose first name starts with M


            //Create a new list for every first name
            List<string> firstNames = new List<string>();

            // Loop through people and add their first names to the list
            foreach (Person person in people)
            {
                firstNames.Add(person.FirstName);
            }

            // Loop through the list of first names
            foreach (Person person in people)
            {
                //Use a string method to determine if the name starts with M
                if (person.FirstName.StartsWith("M"))
                {
                    // Use the ToString method for this person
                    string personInfo = person.ToString();
                    Console.WriteLine($"{personInfo}");
                }
                continue;
            }

            //Display information of person whose favorite color is blue
            foreach (Person person in people)
            {
                string personBlueInfo = person.ToString();
                if (person.FavoriteColour == "Blue")
                {
                    Console.WriteLine($"{personBlueInfo}");
                }
            }
        }


    }
}
