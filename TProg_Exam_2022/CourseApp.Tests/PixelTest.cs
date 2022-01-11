namespace Test
{
    using Exam;
    using Xunit;

    public class PixelTest
    {
        [Fact]
        public void PixelCheckCreatedName()
        {
            AndroidPhone pixel = new ("Google Pixel", 49999.99M, 7.2f);
            Assert.Equal("Google Pixel", pixel.Name);
        }

        [Fact]
        public void PixelCheckCreatedPrice()
        {
            AndroidPhone pixel = new ("Google Pixel", 49999.99M, 7.2f);
            Assert.Equal(49999.99M, pixel.Price);
        }

        [Fact]
        public void PixelCheckCreatedDiagonal()
        {
            AndroidPhone pixel = new ("Google Pixel", 49999.99M, 7.2f);
            Assert.Equal(7.2f, pixel.Diagonal);
        }

        [Fact]
        public void PixelAcceptCall()
        {
            AndroidPhone pixel = new ("Google Pixel", 49999.99M, 7.2f);
            Assert.Equal("Accepting call", pixel.AcceptCall());
        }

        [Fact]
        public void PixelDeclineCall()
        {
            AndroidPhone pixel = new ("Google Pixel", 49999.99M, 7.2f);
            Assert.Equal("Call Declined", pixel.DeclineCall());
        }

        [Fact]
        public void PixelDial()
        {
            AndroidPhone pixel = new ("Google Pixel", 49999.99M, 7.2f);
            Assert.Equal("Dialing person", pixel.Dial());
        }

        [Fact]
        public void PixelReadText()
        {
            AndroidPhone pixel = new ("Google Pixel", 49999.99M, 7.2f);
            Assert.Equal("Reading text", pixel.ReadText());
        }

        [Fact]
        public void PixelSendText()
        {
            AndroidPhone pixel = new ("Google Pixel", 49999.99M, 7.2f);
            Assert.Equal("Sending text", pixel.SendText());
        }
    }
}