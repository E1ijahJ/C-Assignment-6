using System;
using System.Reflection.Metadata.Ecma335;

namespace Shape3D{

  public class Sphere : shape3D{

    public double Radius{get; set;}
    public Sphere(double radius){
      
      Radius = radius;
      Validate();
    }
        public override double GetVolume()
        {
            return(4.0/3.0) * Math.PI* Math.Pow(Radius,3);
        }
        public override double GetSurfaceArea()
        {
            return 4 * Math.PI*Math.Pow(Radius,2);
        }
        public override string Dump()
        {
           string info = "Hello Im a Sphere ny Surface Area is "+ this.GetSurfaceArea()+" and this is my Volume "+ this.GetVolume();

           return info;
        }
        private string  Validate(){
          if(Radius < 0){
           throw new Exception("Radius Must be larger than zero ");

          
          }
          else{
            return "Valdiated";
          }
          
          
          
        }
    }
}