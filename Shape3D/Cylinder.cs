using System;
using System.Reflection.Metadata.Ecma335;

namespace Shape3D{

/// <summary>
/// This is the cylinder class a child of the shape3d class has valeus for radius and height and uses those values to calcualte surface are and vvolume 
/// </summary>
  public class Cylinder: shape3D{

    public double Radius{get; set;}
    public double Height{get;set;}
    public Cylinder(double radius,double height){
      Height=height;
      Radius = radius;
      Validate();
    }
        public override double GetVolume()
        {
            return Math.PI* Math.Pow(Radius,2)*Height;
        }
        public override double GetSurfaceArea()
        {
            return (2 * Math.PI*Math.Pow(Radius,2))+(2*Math.PI*Height*Radius);
        }
        public override string Dump()
        {
           string info = "Hello Im a Cylinder my Surface Area is "+ this.GetSurfaceArea()+" and this is my Volume "+ this.GetVolume();

           return info;
        }
        private string  Validate(){
          if(Radius < 0|| Height< 0){
           throw new Exception("Radius and Height Must be larger than zero ");

          
          }
          else{
            return "Valdiated";
          }
          
          
          
        }
    }
}