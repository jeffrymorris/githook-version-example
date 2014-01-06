using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GithookVersioningExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.GetAssembly(typeof (Program));
            var names =assembly.GetManifestResourceNames();

            foreach (var name in names)
            {
                var resource = assembly.GetManifestResourceStream(name);
                if (resource != null)
                {
                    using (var reader = new StreamReader(resource))
                    {
                        var contents = reader.ReadToEnd();
                        Console.WriteLine("AssemblyVersionInformation: {0}", contents);
                    }
                }
            }
            Console.Read();
        }
    }
}
