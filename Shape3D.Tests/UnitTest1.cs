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
}
