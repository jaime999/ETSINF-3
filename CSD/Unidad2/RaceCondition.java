public class RaceCondition
{
 public static void main(String[] args)
 {
 Counter c = new Counter();
 int loops=1000;
 System.out.println("Loops "+ loops );

 Incrementer inc1 = new Incrementer(c, 1, loops);
 Incrementer inc2 = new Incrementer(c, 2, loops);
 Decrementer dec1 = new Decrementer(c, 1, loops);
 Decrementer dec2 = new Decrementer(c, 2, loops);
 inc1.start(); inc2.start();
 dec1.start(); dec2.start();
 System.out.println("Final result: "+c.value() );
 }
}
