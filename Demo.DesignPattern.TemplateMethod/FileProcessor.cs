namespace Demo.DesignPattern.TemplateMethod
{
    /// <summary>
    /// "AbstractClass" 
    /// - Defines abstract primitive operations that concrete subclasses define to implement steps of an algorithm.
    /// - Implements a template method defining the skeleton of an algorithm. The template method calls primitive operations as well as operations defined in AbstractClass or those of other objects.    /// 
    /// </summary>
    public abstract class FileProcessor
    {
        public abstract string Serialize<T>(T obj);

        /// <summary>
        /// This is the "Template Method" provides a skeleton calling sequence of methods.
        /// </summary>
        /// <param name="file"></param>
        public void Process<T>(T obj)
        {
            // Step #1: Make sure it's not null and all public properties have values
            if (obj is null)
            {
                Console.WriteLine("The object is null. Unable to process.");
                return;
            }

            Console.WriteLine("Info: Object is not null.");

            // Step #2: Serialize the object
            var content = Serialize(obj);

            // Step #3: Output content
            Console.WriteLine(content);
        }
    }
}
