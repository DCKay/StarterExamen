namespace Project1.Data
{
    public class DummyHeadset : IDummyData
    {
        public string DummyData()
        {
            return $"new Headset {{ Id = 1, Title = \"Bose 700 Noise Cancelling Headphones Headset\", SubTitle = \"Pretty sweet TBH\", Rating = 5, Image = \"https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse2.mm.bing.net%2Fth%3Fid%3DOIP.0B_DLoshSJW0je8gzD0IXQHaHa%26pid%3DApi&f=1\", Manufacturer = \"Bose\", Colour = Colour.Black, Name = \"Bose 700\",HasMicro = false, IsWired = false }}";
        }
    }
}