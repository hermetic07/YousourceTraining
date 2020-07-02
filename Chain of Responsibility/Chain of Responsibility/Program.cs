namespace Chain_of_Responsibility
{
    using System;
    using Chain_of_Responsibility.Classes;

    public class Program
    {
        public static void Main(string[] args)
        {
            // JSON Data
            Request request = new Request() 
            {
                ContentType = "json",
                Content = @"{""name"":""John Doe"",""age"":20}"
            };

            RequestParser requestParser = new RequestParser(request);
            requestParser.Parse();

            // XML Data
            request = new Request()
            {
                ContentType = "xml",
                Content = @"<PurchaseOrder>
                                <PurchasedGame>
                                    <Name>GTA</Name>
                                </PurchasedGame>
                                <Customer>
                                    <Name>Evander</Name>
                                </Customer>
                            </PurchaseOrder>"
            };

            requestParser = new RequestParser(request);
            requestParser.Parse();

            // Invalid data
            request = new Request()
            {
                ContentType = "string",
                Content = "test"
            };

            requestParser = new RequestParser(request);
            requestParser.Parse();

            Console.ReadKey();
        }
    }
}
