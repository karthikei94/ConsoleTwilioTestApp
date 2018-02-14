using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Security;
using Twilio.Types;

namespace TwilioApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //TestMethod();

            {
                // Your Account SID from twilio.com/console
                var accountSid = "AC6e08147104ffc4a8a1c9ad142ade2cc8";
                // Your Auth Token from twilio.com/console
                var authToken = "126c98b5de29aae057cbf8302cd2e15d";

                TwilioClient.Init(accountSid, authToken);
                var to = new PhoneNumber("+917981922384");
                var message = MessageResource.Create(
                    to: to,
                    from: new PhoneNumber("+17027105699"),
                    body: "Hello from C# Twilio Test Message");

                Console.WriteLine(message.Sid);
                Console.Write("Press any key to continue.");
                Console.ReadKey();
            }
        }

        private static void TestMethod()
        {
            // Your Auth Token from twilio.com/console
            const string authToken = "your-secret";

            // Initialize the validator
            var validator = new RequestValidator(authToken);

            // The Twilio request URL
            const string url = "https://mycompany.com/myapp.php?foo=1&bar=2";

            // The X-Twilio-Signature header attached to the request
            const string twilioSignature = "RSOYDt4T1cUTdK1PDd93/VVr8B8=";

            var parameters = new Dictionary<string, string>
            {
                {"CallSid", "CA1234567890ABCDE"},
                {"Caller", "+14158675310"},
                {"Digits", "1234"},
                {"From", "+14158675310"},
                {"To", "+18005551212"}
            };

            Console.WriteLine(validator.Validate(url, parameters, twilioSignature));
        }
    }
}
