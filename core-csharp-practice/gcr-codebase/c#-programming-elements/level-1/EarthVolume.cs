using System;
class EarthVolume
{
    public static void Main()
    {
        double radiusKM = 6378;
        double radiusMiles = 6378*0.621371;
        double VolumeKM = (4.0/3)*Math.PI*Math.Pow(radiusKM,3);
        double VolumeMiles = (4.0/3)*Math.PI*Math.Pow(radiusMiles,3);
        Console.WriteLine($"The volume of earth in cubic kilometers is {VolumeKM} and cubic miles is {VolumeMiles}");
    }
}