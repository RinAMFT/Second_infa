using System;

public class Class1
{
    public double chislo1;
    public double chislo2;
    public double product;
    public Class1(double chislo1, double chislo2)
	{
		this.chislo1 = chislo1;
        this.chislo2 = chislo2;
        Resh();
	}
    
    

    public void Output()
    {
        product = chislo1 * chislo2;
        if (product < 0)
        {
            Console.WriteLine("Нет действительных корней.");
        }
        else
        {
            double result = Math.Sqrt(product);
            Console.WriteLine($"Результат: {result}");
        }
    }

}
