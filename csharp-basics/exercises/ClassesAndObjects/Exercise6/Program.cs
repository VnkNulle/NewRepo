using System;

class Dog
{
    public string Name { get; set; }
    public string Sex { get; set; }
    public Dog Mother { get; set; }
    public Dog Father { get; set; }

    public Dog(string name, string sex)
    {
        Name = name;
        Sex = sex;
    }

    public string FathersName()
    {
        return Father != null ? Father.Name : "Unknown";
    }

    public bool HasSameMotherAs(Dog otherDog)
    {
        return Mother != null && otherDog.Mother != null && Mother.Name == otherDog.Mother.Name;
    }
}

class DogTest
{
    static void Main(string[] args)
    {
        Dog max = new Dog("Max", "male");
        Dog rocky = new Dog("Rocky", "male");
        Dog sparky = new Dog("Sparky", "male");
        Dog buster = new Dog("Buster", "male");
        Dog sam = new Dog("Sam", "male");
        Dog lady = new Dog("Lady", "female");
        Dog molly = new Dog("Molly", "female");
        Dog coco = new Dog("Coco", "female");

        max.Mother = lady;
        max.Father = rocky;

        coco.Mother = molly;
        coco.Father = buster;

        rocky.Mother = molly;
        rocky.Father = sam;

        buster.Mother = lady;
        buster.Father = sparky;

        Console.WriteLine("Fathers Name for Coco: " + coco.FathersName());
        Console.WriteLine("Fathers Name for Sparky: " + sparky.FathersName());

        Console.WriteLine("Coco has same mother as Rocky: " + coco.HasSameMotherAs(rocky));
        Console.WriteLine("Coco has same mother as Max: " + coco.HasSameMotherAs(max));
    }
}
