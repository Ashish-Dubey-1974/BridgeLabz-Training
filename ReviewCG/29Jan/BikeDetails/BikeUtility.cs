namespace BikeDetails{
    class BikeUtility
    {
        Dictionary<int,BikeInfo> Bikesdata = new Dictionary<int,BikeInfo>();
        Dictionary<string,IList<BikeInfo>> GroupByBrands = new Dictionary<string, IList<BikeInfo>>();
        public void AddBikeDetails(string m,string b,double p)
        {
            Console.WriteLine("Enter Bike ID : ");
            int ID = int.Parse(Console.ReadLine());
            if (Bikesdata.ContainsKey(ID))
            {
                Console.Write("Bike Is Already Available Use Another ID : ");
                return;
            }
            Bikesdata.Add(ID,new BikeInfo(m,b,p));
            if (GroupByBrands.ContainsKey(b))
            {
                GroupByBrands[b].Add(new BikeInfo(m,b,p));
            }else
            {
                IList<BikeInfo> list = new List<BikeInfo>();
                list.Add(new BikeInfo(m,b,p));
                GroupByBrands.Add(b,list);
            }
            Console.WriteLine("Bike Added Successfully : \n");
        }
        public void ShowBikesBrands()
        {
            foreach (KeyValuePair<string,IList<BikeInfo>> brands in GroupByBrands)
            {
                Console.WriteLine($"Brand Name : {brands.Key}");
                foreach(BikeInfo bike in brands.Value)
                {
                    Console.WriteLine($"Bike Details : {bike}");
                }
                Console.WriteLine();
            }
        }
    }
}