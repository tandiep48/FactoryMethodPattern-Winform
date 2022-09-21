namespace FactoryMethod
{
    public class SaberFactory : ServantFactory
    {
        public override IServant CreateServant()
        {
            return new Saber();
        }
    }
}