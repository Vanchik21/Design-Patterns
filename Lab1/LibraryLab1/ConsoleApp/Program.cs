using LibraryLab1;
public class Program
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal> { new Mammal("Lion", "11Df12", false), new Bird("Parrot", "31Bf32", true), new Reptile("Snake", "24Vf23") };
        List<ZooStaff> employees = new List<ZooStaff> { new ZooStaff("John", "Briks", "Manager"), new ZooStaff("Alice","Watson", "Veterinarian") };
        int feedStocks = 123;

        Inventory inventory = new Inventory(animals, employees, feedStocks);
        inventory.ShowAnimalInventory();
        inventory.ShowFeedStock();
        inventory.ShowStaffsInventory();
    }
}