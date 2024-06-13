namespace SkillsTest;

public enum DogRace { Labrador, Poodle, Bulldog} //Opgave 11
public class Dog
{
    public int ID { get; set; }
    public string Name { get; set; }
    //public string Race { get; set; } //Før opgave 11
    public DogRace Race { get; } //Opgave 11
    public int YearOfBirth { get; set; }

    public Dog(int id, string name, DogRace race, int yearOfBirth)
    {
        ID = id;
        Name = name;
        Race = race;
        YearOfBirth = yearOfBirth;
    }
    
    public string ToString()
    {
        return $"Dog {Name} is of Race {Race} and was born in {YearOfBirth}";
    }
}