using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLab1
{
    public class Inventory
    {
        private List<Animal> animals;
        private List<ZooStaff> staffs;
        private double feedStocks;

        public Inventory(List<Animal> animals, List<ZooStaff> staffs, double feedStocks)
        {
            this.animals = animals;
            this.staffs = staffs;
            this.feedStocks = feedStocks;
        }

        public void ShowAnimalInventory()
        {
            Console.WriteLine("Animals in the inventory:");
            foreach (var animal in animals)
            {
                Console.WriteLine($"Name: {animal.Name}, Vet Passport: {animal.VetPassport}");
            }
        }

        public void ShowStaffsInventory()
        {
            Console.WriteLine($"Total staff: {staffs.Count}");
        }

        public void ShowFeedStock()
        {
            Console.WriteLine($"Feed stock: {feedStocks}");
        }
    }
}
