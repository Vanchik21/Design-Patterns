using VirusPrototype;

class Program
{
    static void Main(string[] args)
    {
        Virus parentVirus = new Virus(2.5, 5, "ParentVirus", "TypeA");
        Virus childVirus1 = new Virus(1.2, 2, "ChildVirus1", "TypeB");
        Virus childVirus2 = new Virus(1.0, 1, "ChildVirus2", "TypeC");
        Virus grandChildVirus = new Virus(0.5, 0, "GrandChildVirus", "TypeD");

        childVirus1.AddChild(grandChildVirus);
        parentVirus.AddChild(childVirus1);
        parentVirus.AddChild(childVirus2);

        Virus clonedParentVirus = parentVirus.Clone();

        Console.WriteLine("Original Parent Virus:");
        DisplayVirusFamily(parentVirus, 0);
        Console.WriteLine("\nCloned Parent Virus:");
        DisplayVirusFamily(clonedParentVirus, 0);
    }

    static void DisplayVirusFamily(Virus virus, int level)
    {
        Console.WriteLine(new string('-', level * 2) + virus.ToString());
        foreach (var child in virus.Children)
        {
            DisplayVirusFamily(child, level + 1);
        }
    }
}
