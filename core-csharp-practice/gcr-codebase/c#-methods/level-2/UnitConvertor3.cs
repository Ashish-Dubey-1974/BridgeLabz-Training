
using System;
class UnitConvertor3
{
    public static double FToC(double f)=>(f-32)*5/9;
    public static double CToF(double c)=>(c*9/5)+32;
    public static double PoundsToKg(double p)=>p*0.453592;
    public static double KgToPounds(double k)=>k*2.20462;
    public static double GallonsToLiters(double g)=>g*3.78541;
    public static double LitersToGallons(double l)=>l*0.264172;
}
