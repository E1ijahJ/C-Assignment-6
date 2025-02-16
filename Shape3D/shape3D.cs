namespace Shape3D;

public abstract class shape3D
{

public string Name{get; set;} = "3D Shape";

public abstract double GetSurfaceArea();


public abstract double GetVolume();

public abstract string Dump();
}


