namespace FactoryMethod
{
    public class LancerFactory : ServantFactory
    {
        public override IServant CreateServant(string inputName,string inputClass,int inputStar,string inputImg)
        {
            return new Lancer(inputName, inputClass, inputStar, inputImg);
        }
    }
}