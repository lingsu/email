using System;
using System.Diagnostics;
using System.Linq;
using Newtonsoft.Json;
using Xunit;

namespace email.Tests
{
    public class EmailSerializerTests
    {
        [Fact]
        public void Can_serialize_and_deserialize_text_email()
        {
            var email = MessageFactory.EmailWithText(1).Single();
            var json = JsonConvert.SerializeObject(email);

            Assert.NotNull(json);

            Trace.WriteLine(json);

            var deserialized = JsonConvert.DeserializeObject<EmailMessage>(json);
            Assert.NotNull(deserialized);
        }
    }
}