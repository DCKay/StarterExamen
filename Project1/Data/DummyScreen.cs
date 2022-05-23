namespace Project1.Data
{
    public class DummyScreen : IDummyData
    {
        public string DummyData()
        {
            return $"new Screen " +
                $"{{ Id = 1, " +
                $"Title = \"MSI Optix G24C4\", " +
                $"SubTitle = \"Pretty sweet TBH\", " +
                $"Rating = 4, " +
                $"Image = \"https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fgts.jo%2Fimage%2Fcache%2Fcatalog%2Fproducts%2Fmonitor%2FMSI%2Fproduct_3_20190819052103_5d5a31bf61d59_1200x1200-1200x1200.png&f=1&nofb=1\", " +
                $"Manufacturer = \"MSI\", " +
                $"Colour = Colour.Black, " +
                $"Name = \"Optix G24C4\", " +
                $"Resolution = \"1440p\", " +
                $"FPS = 144 }}";
        }
    }
}