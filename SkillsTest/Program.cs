namespace SkillsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave 2 & 11
            Console.WriteLine("OPGAVE 2:");
            Dog dog1 = new Dog(1, "Fido", DogRace.Labrador, 2015);
            Dog dog2 = new Dog(2, "Rex", DogRace.Bulldog, 2018);
            Dog dog3 = new Dog(3, "Max", DogRace.Poodle, 2017);
            
            Console.WriteLine($"{dog1.Name} is a {dog1.Race} born in {dog1.YearOfBirth}");
            Console.WriteLine($"{dog2.Name} is a {dog2.Race} born in {dog2.YearOfBirth}");
            Console.WriteLine($"{dog3.Name} is a {dog3.Race} born in {dog3.YearOfBirth}");
            
            //Opgave 3
            Console.WriteLine("\nOPGAVE 3:");
            Member member1 = new Member(1, "John Doe", "fake@gmail.com", "123456789", "123 Fake St", new DateTime(1990, 1, 1));
            Member member2 = new Member(2, "Jane Doe", "fake@gmail.com", "42311253", "531 Fake St", new DateTime(1992, 5, 15));
            Member member3 = new Member(3, "John Smith", "fake@gmail.com", "17456338", "853 Fake St", new DateTime(1954, 8, 27));
            
            Console.WriteLine(member1.ToString());
            Console.WriteLine(member2.ToString());
            Console.WriteLine(member3.ToString());
            
            //Opgave 4
            Console.WriteLine("\nOPGAVE 4:");
            member1.RegisterDog(dog1);
            member1.RegisterDog(dog2);
            member1.RegisterDog(dog3);
            
            member1.PrintDogs();
            
            member1.RemoveDog(dog2);
            
            member1.PrintDogs();
            
            //Opgave 6
            Console.WriteLine("\nOPGAVE 6:");
            Console.WriteLine($"The age of {member1.Name} is {member1.Age}");
            Console.WriteLine($"The age of {member2.Name} is {member2.Age}");
            Console.WriteLine($"The age of {member3.Name} is {member3.Age}");
            
            Console.WriteLine($"Member fee for {member1.Name} is {member1.MemberFee(500)}");
            member1.BirthDate = new DateTime(1955, 1, 1);
            Console.WriteLine($"Member fee for {member1.Name} is {member1.MemberFee(500)}");
            
            //Opgave 7
            Console.WriteLine("\nOPGAVE 7:");
            try
            {
                member1.Validate();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            member1.BirthDate = new DateTime(2022, 1, 1);
            try
            {
                member1.Validate();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}