namespace LibraryLab1
{
    public class ZooStaff
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Position { get; private set; }

        public ZooStaff(string name, string surname, string position)
        {
            Name = name;
            Surname = surname;
            Position = position;
        }
    }
}