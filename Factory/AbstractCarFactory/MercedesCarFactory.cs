namespace AbstractCarFactory
{
    class MercedesCarFactory : AbstractCarFactory
    {
        protected override string Brand => "Mercedes";
        protected override int Price => 45000;
        protected override string Color => "Negru";

    }
}
