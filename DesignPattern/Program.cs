
using DesignPattern.Creational;

ProductCreator productCreator = new ProductCreator();
var productA = productCreator.FactoryMethod("A");
productA.Print();

var productB = productCreator.FactoryMethod("B");
productB.Print();

Console.ReadLine();