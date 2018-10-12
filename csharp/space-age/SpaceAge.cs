using System;

public class SpaceAge
{
    public double ageInSeconds;

    public SpaceAge(long seconds)
    {
        ageInSeconds = seconds / (31557660.0);  
    }

    public double OnEarth()
    {
        return ageInSeconds;
    }

    public double OnMercury()
    {
        return ageInSeconds / 0.2408467;
    }

    public double OnVenus()
    {
        return ageInSeconds / 0.61519726;
    }

    public double OnMars()
    {
        return ageInSeconds / 1.8808158;
    }

    public double OnJupiter()
    {
        return ageInSeconds / 11.862615;
    }

    public double OnSaturn()
    {
        return ageInSeconds / 29.447498;
    }

    public double OnUranus()
    {
        return ageInSeconds / 84.016846;
    }

    public double OnNeptune()
    {
        return ageInSeconds / 164.79132;
    }
}