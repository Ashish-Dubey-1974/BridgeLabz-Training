namespace BikeDetails
{
    class BikeInfo
    {
        string Model;
        string Brand;
        double Price;
        public BikeInfo(string m,string b,double p){
            Model=m;
            Brand=b;
            Price=p;
        }
        public override string ToString()
        {
            return $"Bike Model : {Model} | Brand : {Brand} | Price : {Price}";
        }
    }
}