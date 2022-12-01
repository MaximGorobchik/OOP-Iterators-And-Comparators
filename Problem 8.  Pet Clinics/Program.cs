List<Pet> pets = new List<Pet>();
List<Clinic> clinics= new List<Clinic>();
var n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    var info = Console.ReadLine().Split();
    if (info[0].Equals("Create") && info[1].Equals("Pet"))
    {
        pets.Add(new Pet(info[2], int.Parse(info[3]), info[4]));
    }
    if (info[0].Equals("Create") && info[1].Equals("Clinic"))
    {
        var clinic_name = info[2];
        int rooms_count = int.Parse(info[3]);
        if (rooms_count % 2 != 0)
        {
            clinics.Add(new Clinic(clinic_name, rooms_count));
        }
        else
        {
            Console.WriteLine("Invalid Operation!");
        }
    }
    if (info[0].Equals("HasEmptyRooms"))
    {
        Console.WriteLine(clinics.FirstOrDefault(x => x.clinicName.Equals(info[1])).HasEmptyRooms());
    }
    if (info[0].Equals("Add"))
    {
        var pet = pets.FirstOrDefault(x => x.PetName.Equals(info[1]));
        Console.WriteLine(clinics.FirstOrDefault(x => x.clinicName.Equals(info[2])).AddPet(pet));
    }
    if (info[0].Equals("Release"))
    {
        Console.WriteLine(clinics.FirstOrDefault(x => x.clinicName.Equals(info[1])).Release());
    }
    if (info[0].Equals("Print"))
    {
        if (info.Length == 2)
        {
            var clinic = clinics.FirstOrDefault(x => x.clinicName.Equals(info[1]));
            foreach (Pet pet in clinic)
            {
                if (pet != null)
                {
                    Console.WriteLine(pet);
                }
                else
                    Console.WriteLine("Room Empty");
            }
        }
        else if (info.Length == 3)
        {
            var clinic = clinics.FirstOrDefault(x => x.clinicName.Equals(info[1]));
            var room = int.Parse(info[2]);
            Console.WriteLine(clinic.Print(room));
        }
    }
}