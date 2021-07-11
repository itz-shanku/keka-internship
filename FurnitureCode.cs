using System;

class Furniture{
	private int NoOfLegs{get; set;}
	private int SurfaceArea{get; set;}
	private int Price{get; set;}
	private string Color{get; set;}
	
	public int LegCountGet(){
		return this.NoOfLegs;
	}
	
	protected void LegCountSet(int count){
		this.NoOfLegs = count;
	}
	
	public int SurfaceAreaGet(){
		return this.SurfaceArea;
	}
	
	protected void SurfaceAreaSet(int area){
		this.SurfaceArea = area;
	}
	
	public int PriceGet(){
		return this.Price;
	}
	
	protected void PriceSet(int price){
		this.Price = price;
	}
	
	public string ColorGet(){
		return this.Color;
	}
	
	protected void ColorSet(string color){
		this.Color = color;
	}
}

class Sofa : Furniture{
	private int CushionCount{get; set;}
	
	public Sofa(int LegCount, int Area, int Pricing, string Color, int Cushion){
		this.LegCountSet(LegCount);
		this.SurfaceAreaSet(Area);
		this.PriceSet(Pricing);
		this.ColorSet(Color);
		this.CushionCount = Cushion;
	}
	
	public int CushionGet(){
		return this.CushionCount;
	}
}

class Table : Furniture{
	private string WoodType{get; set;}
	private string Shape{get; set;}
	private int NoOfChair{get; set;}
	
	public Table(int LegCount, int Area, int Pricing, string Color, string WoodName, string TableShape, int ChairCount){
		this.LegCountSet(LegCount);
		this.SurfaceAreaSet(Area);
		this.PriceSet(Pricing);
		this.ColorSet(Color);
		this.WoodType = WoodName;
		this.Shape = TableShape;
		this.NoOfChair = ChairCount;
	}
	
	public string WoodTypeGet(){
		return this.WoodType;
	}
}

class Chair : Furniture{
	private string Design{get; set;}
	
	public Chair(int LegCount, int Area, int Pricing, string Color, string DesignName){
		this.LegCountSet(LegCount);
		this.SurfaceAreaSet(Area);
		this.PriceSet(Pricing);
		this.ColorSet(Color);
		this.Design = DesignName;
	}
	
	public string DesignGetter(){
		return this.Design;
	}
}

class Bed : Furniture{
	private string Mattress{get; set;}
	private int NoOfPillows{get; set;}
	
	public Bed(int LegCount, int Area, int Pricing, string Color, int PillowCount, string MattressName){
		this.LegCountSet(LegCount);
		this.SurfaceAreaSet(Area);
		this.PriceSet(Pricing);
		this.ColorSet(Color);
		this.NoOfPillows = PillowCount;
		this.Mattress = MattressName;
	}
	
	public string MattressGetter(){
		return this.Mattress;
	}
	
	public int PillowCountGetter(){
		return this.NoOfPillows;
	}
}

class Almirah : Furniture{
	private int NoOfDoors;
	private int NoOfSlabs;
	private bool LockerAvailable;
	
	public Almirah(int LegCount, int Area, int Pricing, string Color, int DoorCount, int SlabCount, bool LockerAvailability){
		this.LegCountSet(LegCount);
		this.SurfaceAreaSet(Area);
		this.PriceSet(Pricing);
		this.ColorSet(Color);
		this.NoOfDoors = DoorCount;
		this.NoOfSlabs = SlabCount;
		this.LockerAvailable = LockerAvailability;
	}
	
	public int DoorCountGetter(){
		return this.NoOfDoors;
	}
	
	public int SlabCountGetter(){
		return this.NoOfSlabs;
	}
	
	public bool IsLockerAvailable(){
		return this.LockerAvailable;
	}
}


public class Program{
	public static void Main(){
		Sofa SofaSet = new Sofa(4, 3000, 15000, "Brown", 6);
		Table TableSet = new Table(3, 1532, 17000, "Red", "Rose Wood", "Triangle", 6);
		Chair ChairSet = new Chair(4, 750, 5000, "Black", "Stool");
		Bed Bedding = new Bed(6, 4500, 25000, "Black", 4, "Kurl-On");
		Almirah GodrejAlmirah = new Almirah(4, 4000, 20000, "Golden Yellow", 2, 13, true);
		
		Console.WriteLine("This Sofa contains {0} number of legs.", SofaSet.LegCountGet());
		
		Console.WriteLine("{0} is the surface area of the Table.", TableSet.SurfaceAreaGet());
		
		Console.WriteLine("The cost of this chair is Rs.{0}.", ChairSet.PriceGet());
		
		Console.WriteLine("The Almirah is of {0} color.", GodrejAlmirah.ColorGet());
		
		Console.WriteLine("This Bed comes with a free {0} mattress.", Bedding.MattressGetter());
	}
}