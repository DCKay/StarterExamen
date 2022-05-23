namespace Project1.Data
{
    public class DummyKeySwitch : IDummyData
    {
        public string DummyData()
        {
            return $"new KeySwitch " +
                $"{{ Id = 1, " +
                $"Title = \"Corsair keyswitches\", " +
                $"SubTitle = \"Pretty sweet TBH\", " +
                $"Rating = 4, Image = \"\", " +
                $"Manufacturer = \"Corsair\", " +
                $"Colour = Colour.White, " +
                $"Name = \"Corsair keyswitches\" }}";
        }
    }
}