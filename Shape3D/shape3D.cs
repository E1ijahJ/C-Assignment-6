namespace Shape3D;
/// <summary>
/// this is the shape3D class that allows for all the shapes to inherit this makes sure that all shapes have necesssary functions 
/// </summary>
public abstract class shape3D
{

public string Name{get; set;} = "3D Shape";

public abstract double GetSurfaceArea();


public abstract double GetVolume();

public abstract string Dump();
}


