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
            // a comment
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
            var company = GetCustomAttribute<System.Reflection.AssemblyCompanyAttribute>();
            var product = GetCustomAttribute<System.Reflection.AssemblyProductAttribute>();
            var fileVersion = GetCustomAttribute<System.Reflection.AssemblyFileVersionAttribute>();
            var infoVersion = GetCustomAttribute<System.Reflection.AssemblyInformationalVersionAttribute>();

            var sb = new StringBuilder();
            sb.AppendLine($"Title: {title.Title} FileVer: {fileVersion.Version}");
            sb.AppendLine();
            sb.AppendLine($"Descr: {descr.Description}");
            sb.AppendLine($"InfoVer: {infoVersion.InformationalVersion} Config: {conf.Configuration}");
            sb.AppendLine();
            sb.AppendLine($"Copyright: {copy.Copyright}");
            sb.AppendLine($"Company: {company.Company}");
            sb.AppendLine($"Product: {product.Product}");
            return sb.ToString();
        }
    }
}
