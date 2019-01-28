using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace ConsoleShell
{
    class Program
    {
        private readonly CompositionContainer container;
        private const string catalogWithModules = @"";
        private static IDisposable hangFireServerApp;

        public Program()
        {
            var catalog = new AggregateCatalog();

            catalog.Catalogs.Add(new AssemblyCatalog(typeof(Program).Assembly));
            catalog.Catalogs.Add(new DirectoryCatalog(catalogWithModules));

            container = new CompositionContainer(catalog);

            try
            {
                this.container.ComposeParts(this);
            }
            catch (CompositionException compositionException)
            {
                Console.WriteLine(compositionException.ToString());
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            // Start HangFire Server
            //hangFireServerApp = WebApp.Start<>

            // Add task to sheduller


            Console.ReadLine();
        }
    }
}
