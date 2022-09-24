namespace FactoryMethod
{
    public abstract class ServantFactory
    {
        public abstract IServant CreateServant(string inputName, string inputClass, int inputStar ,string inputImg);
    }
}