using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void TriangleConstructor_CreateInstanceOfTriangle_Triangle()
    {
      Triangle triangle = new Triangle(1, 2, 3);
      Assert.AreEqual(typeof(Triangle), triangle.GetType());
    }
    [TestMethod]
    public void TriangleConstructor_AddsSidesProperty_Triangle()
    {
      Triangle triangle = new Triangle(1,2,3);
      Assert.AreEqual(1, triangle.Side1);
      Assert.AreEqual(2, triangle.Side2);
      Assert.AreEqual(3, triangle.Side3);
    }

    [TestMethod]
    public void TypeTri_AddsSidesProperty_Triangle()
    {
      Triangle triangle = new Triangle(1,2,3);
      Assert.AreEqual(1, triangle.Side1);
      Assert.AreEqual(2, triangle.Side2);
      Assert.AreEqual(3, triangle.Side3);
    }
  }
}