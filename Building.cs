namespace constructeur;
class Building
{
    public double height;
    public double floorNumbers;
    
    public Building(double floorNumbers, double height){
        this.height = height;
        this.floorNumbers = Convert.ToInt32(floorNumbers);
    }

    public Building(double size) : this(size, size){
        this.height = 3 * size;
    }
    
    public double GetFloorMaxSize(){
        return this.height / this.floorNumbers;
    }

    public double GetFloorCount(){
        return this.floorNumbers;
    }

    public double GetSize(){
        return this.height;
    }

    public static void Menu(){
        Console.Clear();
        Console.WriteLine("Give a size: ");
        string keyinput = Console.ReadLine();
        Building b = new Building(Convert.ToDouble(keyinput));
        Console.WriteLine("Floor max size: " + b.GetFloorMaxSize());
        Console.WriteLine("Number of floors: " + b.GetFloorCount());
        Console.WriteLine("Building size: " + b.GetSize());
        Console.ReadLine();
        Menu();
    }
    static void Main(string[] args)
    { 
        Menu();
    }
}
