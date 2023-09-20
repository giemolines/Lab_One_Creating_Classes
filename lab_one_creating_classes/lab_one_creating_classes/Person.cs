using System;

namespace lab_one_creating_classes
{
    internal class Person
    {
        private int personId;
        private string firstName = "";
        private string lastName = "";
        private string favoriteColour = "";
        private int age;
        private bool isWorking;

        // Properties 
        public int ID
        {
            get { return personId; }
            set { personId = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FavoriteColour
        {
            get { return favoriteColour; }
            set { favoriteColour = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public bool IsWorking
        {
            get { return isWorking; }
            set { isWorking = value; }
        }

        //

        public Person(int personId, string firstName, string lastName,
            int age, string favoriteColour, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.favoriteColour = favoriteColour;
            this.isWorking = isWorking;
        }

        // METHODS
        public string DisplayPersonInfo()
        {
            return $"{ID}: {FirstName} {LastName}'s favorite colour is {FavoriteColour}";
        }

        public void ChangeFavoriteColour()
        {
            FavoriteColour = "White";
        }

        public int GetAgeInTenYears()
        {
            int ageInTenYears = Age + 10;
            return ageInTenYears;
        }

        public override string ToString()
        {
            return $"PersonId:{ID}\nFirstName: {FirstName}\nLastName: " +
                $"{LastName}\nFavoriteColour: {FavoriteColour}\nAge: " +
                $"{Age}\nIsWorking: {IsWorking}";
        }
    }
}
