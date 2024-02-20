namespace LibraryLab1
{
    public class ZooStaff
    {
        protected string Name { get; set; }
        protected string Surname { get; set; }
        protected string Position { get; set; }

        public ZooStaff(string name, string surname, string position)
        {
            Name = name;
            Surname = surname;
            Position = position;
        }
    }
}
