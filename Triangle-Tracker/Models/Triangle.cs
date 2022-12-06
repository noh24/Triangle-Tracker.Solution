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
    public string TypeOfTriangle()
    {
      // If any side is longer than the other two sides combined, the lengths cannot form a triangle.
      if (Side1 > (Side2 + Side3) || Side2 > (Side1 + Side3) || Side3 > (Side1 + Side2))
      {
        return "not triangle";
      } else {
        // Equilateral: All sides are equal; side = side 
        if (Side1 == Side2 && Side2 == Side3)
        {
          return "equilateral";
        } 
        // Isosceles: Exactly 2 sides are equal
        else if (Side1 == Side2 || Side2 == Side3 || Side1 == Side3)
        {
          return "isosceles";
        } 
        // Scalene: No sides are equal
        else
        {
          return "scalene";
        }
      }
    }
  }
}