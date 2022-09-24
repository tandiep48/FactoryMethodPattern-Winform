namespace FactoryMethod
{
    public class Lancer : IServant
    {
       public string servantName { get; set; }
        public string servantClass { get; set; }
        public int servantStar { get; set; }
        public string servantImg { get; set; }
        public Lancer(string servantName, string servantClass,int servantStar, string servantImg)
        {
            this.servantName = servantName;
            this.servantClass = servantClass;
            this.servantStar = servantStar;
            this.servantImg = servantImg;
        }

        public string getMyName()
        {
            return this.servantName;
        }

        public string getMyClass()
        {
            return this.servantClass;
        }

        public int getMyStar()
        {
           return this.servantStar;
        }

        public string getMyImg()
        {
            return this.servantImg;
        }
    }
}