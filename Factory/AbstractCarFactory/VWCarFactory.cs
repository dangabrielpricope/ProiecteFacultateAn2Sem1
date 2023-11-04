namespace AbstractCarFactory
{
    class VWCarFactory : AbstractCarFactory
    {
        protected override string Brand => "VW";
        protected override int Price => 30000;
        protected override string Color => "Albastru";
    }
}
