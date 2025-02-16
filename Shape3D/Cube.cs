using System;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

namespace Shape3D{
/// <summary>
/// Cube class which has jus one parameter  to kind of pass over the necessary require ment of l w and h making sure that we keep it simple
/// </summary>
  public class Cube : shape3D{

    public double Side{get;}
    public Cube(double side){
      
      Side = side;
      Validate();
    }
        public override double GetVolume()
        {
            return Math.Pow(Side,3);
        }
        public override double GetSurfaceArea()
        {
            return 6* Math.Pow(Side,2);
        }
        public override string Dump()
        {
         string info = "Hello Im a Cube "+ "my surface area is "+ this.GetSurfaceArea()+ " and my volume is "+ this.GetVolume(
         );
         
         return info;
        }

        private string  Validate(){
          if(Side < 0){
           throw new Exception("Side Length Must be larger than zero ");

          
          }
          else{
            return "Valdiated";
          }
          
          
          
        }
    }
}