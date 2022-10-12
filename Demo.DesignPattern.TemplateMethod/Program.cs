namespace Demo.DesignPattern.TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new()
            {
                Id = 1,
                Username = "Jon Doe"
            };

            var xmlFileProcessor = new XmlProcessor();
            var jsonFileProcessor = new JsonProcessor();

            xmlFileProcessor.Process(user);
            jsonFileProcessor.Process(user);
        }
    }
}