using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetHeader());
            Console.WriteLine();
            Console.WriteLine("Hello world!");
        }

        static private T GetCustomAttribute<T>()
            where T : Attribute
        {
            return System.Reflection.Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(T), false).FirstOrDefault() as T;
        }

        static internal string GetHeader()
        {
            var title = GetCustomAttribute<System.Reflection.AssemblyTitleAttribute>();
            var descr = GetCustomAttribute<System.Reflection.AssemblyDescriptionAttribute>();
            var conf = GetCustomAttribute<System.Reflection.AssemblyConfigurationAttribute>();
            var copy = GetCustomAttribute<System.Reflection.AssemblyCopyrightAttribute>();
            var fileVersion = GetCustomAttribute<System.Reflection.AssemblyFileVersionAttribute>();
            var infoVersion = GetCustomAttribute<System.Reflection.AssemblyInformationalVersionAttribute>();

            var sb = new StringBuilder();
            sb.AppendFormat("{0} {1}", title.Title, infoVersion.InformationalVersion);
            sb.AppendLine();
            sb.AppendLine(descr.Description);
            sb.AppendFormat("Build: {0}/{1}", fileVersion.Version, conf.Configuration);
            sb.AppendLine();
            sb.AppendLine(copy.Copyright);

            return sb.ToString();
        }
    }
}
