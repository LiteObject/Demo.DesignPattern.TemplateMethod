using System.Xml.Serialization;

namespace Demo.DesignPattern.TemplateMethod
{
    public class XmlProcessor : FileProcessor
    {
        public override string Serialize<T>(T obj)
        {
            /*
             *  It is important to use toSerialize.GetType() instead of typeof(T) in 
             *  XmlSerializer constructor. If you use the first one the code covers 
             *  all possible subclasses of T (which are valid for the method), while 
             *  using the latter one will fail when passing a type derived from T.   
             */


            XmlSerializer xmlSerializer = new(obj.GetType());

            using (StringWriter textWriter = new())
            {
                xmlSerializer.Serialize(textWriter, obj);
                return textWriter.ToString();
            }
        }
    }
}
