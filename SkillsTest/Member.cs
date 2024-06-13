namespace SkillsTest;

public class Member
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public DateTime BirthDate { get; set; }
    public List<Dog> Dogs { get; set; }
    public int Age => DateTime.Now.Year - BirthDate.Year;
    
    public Member(int id, string name, string email, string phone, string address, DateTime birthDate)
    {
        ID = id;
        Name = name;
        Email = email;
        Phone = phone;
        Address = address;
        BirthDate = birthDate;
        Dogs = new List<Dog>();
    }
    
    public string ToString()
    {
        return $"{Name} was born on {BirthDate} and their address is {Address} with the email {Email} and phone number {Phone}";
    }
    
    public void RegisterDog(Dog dog)
    {
        Dogs.Add(dog);
        Console.WriteLine($"Added new dog {dog.Name} to {Name}");
    }
    
    public void PrintDogs()
    {
        foreach (var dog in Dogs)
        {
            Console.WriteLine(dog.ToString());
        }
    }

    public void RemoveDog(Dog dog)
    {
        Dogs.Remove(dog);
        Console.WriteLine($"Removed dog {dog.Name} from {Name}");
    }
    
    public double MemberFee(double baseFee)
    {
        double totalFee = 1000 + Dogs.Count() * baseFee;
        if (Age >= 65)
        {
            totalFee = totalFee - 500;
        }
        
        //Opgave 10 - User Stories 2
        foreach (var dog in Dogs)
        {
            DateTime dogDateTime = new DateTime(dog.YearOfBirth, 1, 1); 
            int dogYear = DateTime.Now.Year - dogDateTime.Year;
            if (10 < dogYear)
            {
                totalFee = totalFee - 250;
            }
        }
        
        //Opgave  10 - User Stories 1
        foreach (var dog in Dogs)
        {
             if (dog.Name == "Arthur")
             {
                 totalFee = totalFee * 0.5;
             }
        }
        
        return totalFee;
    }

    public bool Validate()
    {
        if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Phone) || string.IsNullOrEmpty(Address) || Age < 18)
        {
            throw new Exception("Member er ikke gyldig!");
            //Opgave 7 Console.WriteLine("Member er ikke gyldig!");
            //Opgave 7 return false;
        }
        Console.WriteLine("Member er gyldig!");
        return true;
    }
    
}