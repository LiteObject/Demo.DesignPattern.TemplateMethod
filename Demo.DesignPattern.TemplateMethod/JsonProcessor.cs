using System.Text.Json;

namespace Demo.DesignPattern.TemplateMethod
{
    public class JsonProcessor : FileProcessor
    {
        public override string Serialize<T>(T obj)
        {
            return JsonSerializer.Serialize(obj);
        }
    }
}
