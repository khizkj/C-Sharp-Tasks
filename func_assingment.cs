using System;
class HelloWorld {
    static int add(int x,int y){
        return x+y;
    }
    static int subtract(int x,int y){
        return x-y;
    }
    static int multiply(int x,int y){
        return x*y;
    }
    static double devide(double x,double y){
        return x/y;
    }
    static int square(int x){
        return x*x;
    }
    static int cube(int x){
        return x*x*x;
    }
    static double averageof2(double x,double y){
        return x+y/2;
    }
  static void Main() {
     int a = 25;
     int b = 55;
     int c = 4;
      
      Console.WriteLine(a +" + "+ b +" = "+add(a,b));
      Console.WriteLine(a +" - "+ b +" = "+subtract(a,b));
      Console.WriteLine(a +" * "+ b +" = "+multiply(a,b));
      Console.WriteLine(a +" / "+ b +" = " +devide(a,b));
      Console.WriteLine("The Square of "+c+" is "+square(c));
      Console.WriteLine("The Cube of "+c+" is "+cube(c));
      Console.WriteLine("The average of "+a+ " and " +b+" is "+averageof2(a,b));
    
  }
}