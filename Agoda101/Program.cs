using System;

namespace Agoda101
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null || args.Length == 0)
                args = new string[] { "Anonymous" };

            var name = args[0];
            
            var service = new Security();

            var allowed = service.LetMeIn(name);
            var message = default(string);

            if (allowed)
                message = string.Format("{0} is allowed in", name);
            else
                message = string.Format("{0} is not allowed in", name);

            Console.WriteLine(message);
        }
    }
}
