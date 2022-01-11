namespace Test
{
    using Exam;
    using Xunit;

    public class ApplePhoneTest
    {
        [Fact]
        public void ApplePhoneCheckCreatedName()
        {
            ApplePhone iphone = new ("Apple iPhone 13", 149999.99M, 8.2f);
            Assert.Equal("Apple iPhone 13", iphone.Name);
        }

        [Fact]
        public void ApplePhoneCheckCreatedPrice()
        {
            ApplePhone iphone = new ("Apple iPhone 13", 149999.99M, 8.2f);
            Assert.Equal(149999.99M, iphone.Price);
        }

        [Fact]
        public void ApplePhoneCheckCreatedDiagonal()
        {
            ApplePhone iphone = new ("Apple iPhone 13", 149999.99M, 8.2f);
            Assert.Equal(8.2f, iphone.Diagonal);
        }

        [Fact]
        public void ApplePhoneAcceptCall()
        {
            ApplePhone iphone = new ("Apple iPhone 13", 149999.99M, 8.2f);
            Assert.Equal("Accepting call", iphone.AcceptCall());
        }

        [Fact]
        public void ApplePhoneDeclineCall()
        {
            ApplePhone iphone = new ("Apple iPhone 13", 149999.99M, 8.2f);
            Assert.Equal("Call Declined", iphone.DeclineCall());
        }

        [Fact]
        public void ApplePhoneDial()
        {
            ApplePhone iphone = new ("Apple iPhone 13", 149999.99M, 8.2f);
            Assert.Equal("Dialing person", iphone.Dial());
        }

        [Fact]
        public void ApplePhoneReadText()
        {
            ApplePhone iphone = new ("Apple iPhone 13", 149999.99M, 8.2f);
            Assert.Equal("Reading text", iphone.ReadText());
        }

        [Fact]
        public void ApplePhoneSendText()
        {
            ApplePhone iphone = new ("Apple iPhone 13", 149999.99M, 8.2f);
            Assert.Equal("Sending text", iphone.SendText());
        }
    }
}