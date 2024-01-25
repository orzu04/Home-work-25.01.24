

public class Circle
{
    double radius;
     double pi=3.14;
     public Circle(double radius)

     
     {
       this.radius = radius;


     }

     public Circle()
     {

        
     }

     public void SetRadius(double radius)
     {
        this.radius = radius;

     } 
     public double GetRadius()
     {
        return radius;
     }
     public double GetArea()
     {
        return pi*radius* radius;
        
        
     
     }

     public double GetDiameter()
     {
        return radius*2;
     }
      public double GetCircumference()
      {
        return 2*pi;
      }

}

