namespace Virgin_and_Vilain
{
    internal interface IHero
    {
        string Id { get; set; }
        string Type { get; set; }

        void Description();
    }
}