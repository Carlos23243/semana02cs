using System;

public class Circulo
{
       public double Radio;

    
    public double CalcularArea()
    {
        
        return Math.PI * Radio * Radio;
    }

    
    public double CalcularCircunferencia()
    {
        
        return 2 * Math.PI * Radio;
    }
}