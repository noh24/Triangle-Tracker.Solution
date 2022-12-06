namespace TriangleTracker
{
  public class Triangle
  {
    // auto properties
    public int Side1 {get; set;}
    public int Side2 {get; set;}
    public int Side3 {get; set;}
    // constructor
    public Triangle(int side1, int side2, int side3)
    {
      Side1 = side1;
      Side2 = side2;
      Side3 = side3;
    }
    // method
      // blah
  }
}
//constructor 3arg 
  // side 1
  // side 2
  // side 3

// TypeOfTriangle() -> Method
  // side1 + side2 < side3
  // If any side is longer than the other two sides combined, the lengths cannot form a triangle. 
    // Equilateral: All sides are equal; side = side 
    // Isosceles: Exactly 2 sides are equal; 
    // Scalene: No sides are equal.