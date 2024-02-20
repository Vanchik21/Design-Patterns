using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLab1
{
    public class Inventory
    {
        protected List<Animal> animals;
        protected List<ZooStaff> staffs;
        protected double feedStocks;

        public Inventory(List<Animal> animals, List<ZooStaff> staffs, double feedStocks)
        {
            this.animals = animals;
            this.staffs = staffs;
            this.feedStocks = feedStocks;
        }

        public void ShowAnimalInventory()
        {
            foreach (var animal in animals)
            {
                Console.WriteLine("Animals: " + animal.Name);
            }
        }

        public void ShowStaffsInventory()
        {
            Console.WriteLine("Total stuff: " + staffs.Count );
        }

        public void ShowFeedStock()
        {
            Console.WriteLine("Feed stock: " + feedStocks);
        }
    }
}
