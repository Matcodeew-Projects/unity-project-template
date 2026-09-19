using NUnit.Framework;

public class GridTests
{
    [Test]
    public void Grid_Should_Have_Correct_Width()
    {
        int width = 11;

        Assert.AreEqual(10, width); 
    }
}