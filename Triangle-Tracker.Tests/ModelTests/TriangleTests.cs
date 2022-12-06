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
    public void TypeOfTriangle_IsNotTriangle_NotTriangle()
    {
      Triangle triangle = new Triangle(6,2,3);
      Assert.AreEqual("not triangle", triangle.TypeOfTriangle());
    }

    [TestMethod]
    public void TypeOfTriangle_IsEquilateralTriangle_Equilateral()
    {
      Triangle triangle = new Triangle(3,3,3);
      Assert.AreEqual("equilateral", triangle.TypeOfTriangle());
    }

    [TestMethod]
    public void TypeOfTriangle_IsIsoscelesTriangle_Isosceles()
    {
      Triangle triangle = new Triangle(3,2,3);
      Assert.AreEqual("isosceles", triangle.TypeOfTriangle());
    }

    [TestMethod]
    public void TypeOfTriangle_IsScaleneTriangle_Scalene()
    {
      Triangle triangle = new Triangle(3,2,1);
      Assert.AreEqual("scalene", triangle.TypeOfTriangle());
    }
  }
}