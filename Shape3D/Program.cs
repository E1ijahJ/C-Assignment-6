using System;
using System.ComponentModel;

namespace Shape3D{

class Program{

static void Main(){
ShapeContainer container = new ShapeContainer();
bool active = true;

while(active){
Console.WriteLine("Choose an option\n");
Console.WriteLine("1. Create a shape ");
Console.WriteLine("2 Get a Shape");
Console.WriteLine("3. Delete a Shape");
Console.WriteLine("4. Exit App");



string choice = Console.ReadLine();

switch (choice)
{
  case "1":
                    // 🎯 Ask user for shape type & dimensions
                    Console.WriteLine("Choose a shape: (cube, sphere, cylinder)");
                    string shapeType = Console.ReadLine().ToLower();

                    if (shapeType == "cube")
                    {
                        Console.Write("Enter side length: ");
                        double side = Convert.ToDouble(Console.ReadLine());

                        Cube newCube = new Cube(side);
                        container.Create(newCube); // Add to ShapeContainer
                        Console.WriteLine(newCube.Dump()); // Print shape info
                    }
                    else if(shapeType == "sphere"){
                      Console.Write("Enter radius: ");
                      double radius = Convert.ToDouble(Console.ReadLine());
                      Sphere sphere = new Sphere(radius);
                      container.Create(sphere);
                      Console.WriteLine(sphere.Dump());
                    }
                    else if (shapeType == "cylinder"){
                      Console.WriteLine("Enter Height: ");
                      double height = Convert.ToDouble(Console.ReadLine());
                      Console.WriteLine("Enter radius: ");
                      double radius = Convert.ToDouble(Console.ReadLine());
                      Cylinder cylinder = new Cylinder(height, radius);
                      container.Create(cylinder);
                      Console.WriteLine(cylinder.Dump());
                    }
                    // ➜ Add cases for sphere & cylinder

                    break;

                case "2":
                    // 🎯 Ask user for index and retrieve shape
                    Console.Write("Enter shape index: ");
                    int index = Convert.ToInt32(Console.ReadLine());

                    shape3D shape = container.Get(index);
                    if (shape != null)
                    {
                        Console.WriteLine(shape.Dump()); // Print shape info
                    }
                    else
                    {
                        Console.WriteLine("Invalid index. No shape found.");
                    }
                    break;

                case "3":
                    // 🎯 Ask user for index and delete shape
                    Console.Write("Enter shape index to delete: ");
                    int deleteIndex = Convert.ToInt32(Console.ReadLine());

                    bool deleted = container.Delete(deleteIndex);
                    if (deleted)
                    {
                        Console.WriteLine("Shape successfully deleted.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid index. Deletion failed.");
                    }
                    break;

                case "4":
                    active = false;
                    Console.WriteLine("Exiting program.");
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;

}
}





}

}

}