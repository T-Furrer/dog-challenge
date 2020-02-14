using System;

namespace dog_challenge
{
    public class Dog {

            public Dog(string name, string owner, int age, Gender gender)
            {
                this.name = name;
                this.owner = owner;
                this.age = age;
                this.gender = gender;
            }

            public void Bark(int numBarks)
            {
                for (int i = 0; i < numBarks; i++)
                {
                    Console.WriteLine("Woof!");
                }
            }

            public string GetTag()
            {
                string pronoun;
                string pronoun2;
                if(gender == Gender.Male){
                    pronoun = "His";
                    pronoun2 = "he";
                }
                else {
                    pronoun = "Her";
                    pronoun2 = "she";
                }
                return "If lost, call " + owner + ". " + pronoun + " name is " + name + " and " + pronoun2 + " is " + age + " years old.";
            }

            public string name;
            public string owner;
            public int age;
            public Gender gender;
    }
    class Program
    {
        static void Main(string[] args) {
            Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);  // create object instance
            puppy.Bark(3); // output: Woof!Woof!Woof!
            Console.WriteLine(puppy.GetTag());

            Dog myDog = new Dog("Lileu", "Dale", 4, Gender.Female);  // create object instance
            myDog.Bark(1); // output: Woof!
            Console.WriteLine(myDog.GetTag()); 
        }
    }
    public enum Gender
    {
        Male,
        Female
    };
}
