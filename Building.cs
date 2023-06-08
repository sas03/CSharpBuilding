namespace constructeur;
class Building
{
    public double height;
    public double floorNumbers;
    
    public Building(double floorNumbers, double height){
        this.height = height;
        this.floorNumbers = floorNumbers;
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

    static void Main(string[] args)
    {
        Building b = new Building(4);
        Console.WriteLine("Floor max size: " + b.GetFloorMaxSize());
        Console.WriteLine("Number of floors: " + b.GetFloorCount());
        Console.WriteLine("Building size: " + b.GetSize());
    }
}
