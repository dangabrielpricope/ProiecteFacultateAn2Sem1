namespace AbstractCarFactory
{
    class VolvoCarFactory : AbstractCarFactory
    {
        protected override string Brand => "Volvo";
        protected override int Price => 80000;
        protected override string Color => "Green";
    }
}
