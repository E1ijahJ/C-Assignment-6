using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Shape3D{
/// <summary>
/// This is the the shape container class with 3 simple methods to add, retireve
/// as well as delete a shape from the list
/// </summary>
public class ShapeContainer{
private List<shape3D> shapes;
  public ShapeContainer(){
  shapes = new List<shape3D>();
  }
  public void Create(shape3D shape){
    shapes.Add(shape);
    
  }
  public shape3D Get(int index){
    
  return shapes[index];
  }

  public bool Delete(int index){
    shapes.RemoveAt(index);
    return true;
  }
}


}
