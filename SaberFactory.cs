namespace FactoryMethod
{
    public class SaberFactory : ServantFactory
    {
        public override IServant CreateServant(string inputName,string inputClass,int inputStar,string inputImg)
        {
            return new Saber(inputName, inputClass, inputStar, inputImg);
        }
    }
}