public class Pet
{
    public string PetName { get; set; }
    public int PetAge { get; set; }
    public string PetKind { get; set; }

    public Pet(string name, int age, string kind)
    {
        this.PetName = name;
        this.PetAge = age;
        this.PetKind = kind;
    }
    public override string ToString()
    {
        return $"{this.PetName} {this.PetAge} {this.PetKind}";
    }
}
