namespace FactoryMethod
{
    public class LancerFactory : ServantFactory
    {
        public override IServant CreateServant()
        {
            return new Lancer();
        }
    }
}