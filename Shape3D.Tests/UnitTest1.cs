namespace Shape3D.Tests;

public class UnitTest1
{
    [Fact]
    public void TestingDumpToEnsureThatThereAreNOISsues()
    {
       Cube cube = new Cube(2);

       cube.Dump();

       Console.WriteLine(cube.Dump());
    }



    [Fact]
    public void TestingCylinderDumpToEnsureThatThereAreNOISsues()
    {
       Cylinder cylinder = new Cylinder(3,5);

       

       Console.WriteLine(cylinder.Dump());
    }
}
