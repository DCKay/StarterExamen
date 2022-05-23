namespace Project1.Data
{
    public class DummyMousemat : IDummyData
    {
        public string DummyData()
        {
            return $"new Mousemat " +
                $"{{ Id = 1, " +
                $"Title = \"Corsair MM300 Pro Premium Spill-Proof Cloth Gaming Extended Muismat\", " +
                $"SubTitle = \"Pretty sweet TBH\", Rating = 3, " +
                $"Image = \"https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fpisces.bbystatic.com%2Fimage2%2FBestBuy_US%2Fimages%2Fproducts%2F6428%2F6428301cv12d.jpg&f=1&nofb=1\", " +
                $"Manufacturer = \"Corsair\", " +
                $"Colour = Colour.Black, " +
                $"Name = \"MM300 Pro\", " +
                $"Size = Size.XL }}";
        }
    }
}