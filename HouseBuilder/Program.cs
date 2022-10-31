// See https://aka.ms/new-console-template for more information
using HouseBuilder;


var director = new Director();
var woodenHouseBuilder = new WoodenHouseBuilder();
var concreteHouseBuilder = new ConcreteHouseBuilder();
var newHouse = HouseMaker.MakeMeAHouse(TypeOfWalls.Wooden, false, false, true);
Console.WriteLine("Finished house:\n");
newHouse.PresentThisHouse();

