using System.Collections;

public class Clinic : IEnumerable<Pet>
{
    public string clinicName;
    private Pet[] rooms;
    public Clinic(string name, int rooms)
    {
        this.clinicName = name;
        this.rooms = new Pet[rooms];
    }
    public Pet[] Rooms { get { return this.rooms; } }
    public bool AddPet(Pet pet)
    {
        int middleRoom = this.Rooms.Length / 2;
        if (this.Rooms[middleRoom] == null)
        {
            this.Rooms[middleRoom] = pet;
            return true;
        }
        int awayindex = 1;
        while (true)
        {
            int leftroom = middleRoom - awayindex;
            if (leftroom >= 0 && this.Rooms[leftroom] == null)
            {
                this.Rooms[leftroom] = pet;
                return true;
            }
            int rightroom = middleRoom + awayindex;
            if (rightroom < leftroom && this.Rooms[rightroom] == null)
            {
                this.Rooms[rightroom] = pet;
                return true;
            }
            awayindex++;
            if (awayindex > middleRoom)
            {
                return false;
            }
        }

    }
    public bool Release()
    {
        int middleRoom = this.Rooms.Length / 2;
        int room_check = 0;
        while (true)
        {
            if (this.Rooms[middleRoom % this.Rooms.Length] != null)
            {
                this.Rooms[middleRoom % this.Rooms.Length] = null;
                return true;
            }
            room_check++; 
            if (this.Rooms.Length == room_check) // Якщо room_check = room.length, то це означає що ми пройшли всі кімнати
            {
                return false;
            }
            middleRoom++;
        }
    }
    public bool HasEmptyRooms()
    {
        return this.Rooms.Any(x => x == null);
    }
    public string Print(int clinic)
    {
        if (this.Rooms[clinic - 1] != null)
        {
            return this.Rooms[clinic - 1].ToString();
        }
        return "Room Empty";
    }
    public IEnumerator<Pet> GetEnumerator()
    {
        foreach (Pet pet in this.Rooms)
        {
            yield return pet;
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}
