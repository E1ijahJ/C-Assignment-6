using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Shape3D{

public class ShapeContainer{
private List<shape3D> shapes;
  public ShapeContainer(){
  shapes = new List<shape3D>();
  }
  public void Create(shape3D shape){
    shapes.Add(shape);
    
  }
  public string Get(int index){
    
  return shapes[index].Dump();
  }

  public void Delete(int index){
    shapes.RemoveAt(index);

  }
}


}
