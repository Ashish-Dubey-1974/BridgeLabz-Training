using System;

class TemparatureAnalyser
{
    // ================================= DATA =========================================>
    static int numberOfDays = 7;
    static int numberOfHours = 24;
    static float[,] TemaparatureArray = new float[numberOfDays,numberOfHours];
    static float[] AvgTemparatureOFDay = new float[numberOfDays];
    static string[] DayOfWeek = {"Sunday","Monday","Tuesday","Wednesday","Thrusday","Friday","Saturday"};
    // ===================================Start the Application=============================>
    static void Main()
    {
        TemparatureAnalyser obj = new TemparatureAnalyser();
        obj.FillData();
        obj.AvgTemparatureOF_PerDay();
        while (true)
        {
            Console.WriteLine("\nMenu --->\nTo Find Hottest and Coldest Temparature of the Day Press 1 :\nTo Find Average Temparature of Every Day Press 2:\nTo Exit press 3 ");
            int input = Convert.ToInt16(Console.ReadLine());
            switch (input)
            {
                case 1 :
                    obj.PrintHottestAndColdest();
                    break;
                case 2 :
                    obj.PrintAvgTemp_PerDay();
                    break;
                default :
                    return;
            }
        }
        
        
    }

    // ================================fill data =======================================>
    void FillData()
    {
        Random r = new Random();
        int MaximumTemparature = 50;
        int MinimumTemparature = 10;
        for(int i = 0; i < numberOfDays; i++){
            for(int j = 0; j < numberOfHours; j++){
                TemaparatureArray[i,j] = (float)(r.NextDouble()*(MaximumTemparature-MinimumTemparature)+MinimumTemparature);
            }
        }
    }
    
    // ==================================================Print the Data============================>
    void PrintData()
    {
        for(int i = 0; i < numberOfDays; i++){
            for(int j = 0; j < numberOfHours; j++){
                Console.Write( TemaparatureArray[i,j]+" ");
            }Console.WriteLine();
        }
    }
    // =================================================== Calculate Avg Temparature of Per Day======>
    void AvgTemparatureOF_PerDay()
    {
        for(int i = 0; i < numberOfDays; i++){
            float averageOfDay = 0;
            for(int j = 0; j < numberOfHours; j++){
                averageOfDay+=TemaparatureArray[i,j];
            }AvgTemparatureOFDay[i] = averageOfDay/numberOfHours;
        }
    }

    // ======================================= Hottest And Coldest Day Data  ===========================>
    void PrintHottestAndColdest(){
        for(int j = 0; j < numberOfDays; j++)
        {
        float ColdestTemparature=TemaparatureArray[j,0];
        float HottestTemparature=TemaparatureArray[j,0];
        Console.Write($"{DayOfWeek[j%7]}   -> ");
        for(int i = 0; i < numberOfHours; i++)
        {
            // Calculate Minimum Temparature
            if (ColdestTemparature > TemaparatureArray[j,i])ColdestTemparature = TemaparatureArray[j,i];
            // Calculate Maximum Temparature
            if (HottestTemparature < TemaparatureArray[j,i])HottestTemparature = TemaparatureArray[j,i];
        }
        Console.WriteLine($"Hottest Temparature : {HottestTemparature}    Coldest Temparature : {ColdestTemparature}");
        }
    }

    // =============================================Print Avarage Temparature PerDay===================>

    void PrintAvgTemp_PerDay()
    {
        for(int i = 0; i < numberOfDays; i++)
        {
            Console.WriteLine($"Day -> {DayOfWeek[i%7]} Average Temparature : {AvgTemparatureOFDay[i]}");
        }
    }


}