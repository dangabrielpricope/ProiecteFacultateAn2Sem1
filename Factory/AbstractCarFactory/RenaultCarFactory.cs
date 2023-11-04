namespace AbstractCarFactory
{
    class RenaultCarFactory : AbstractCarFactory
    {
        protected override string Brand => "Renault";
        protected override int Price => 20000;
        protected override string Color => "Rosu";
    }
}
