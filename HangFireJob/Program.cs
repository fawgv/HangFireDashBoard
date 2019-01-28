using Hangfire;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangFireJob
{
    class Program
    {
        static void Main(string[] args)
        {
            GlobalConfiguration.Configuration.UseSqlServerStorage("Server=(local);Database=HangFireDashBoard;Integrated Security=true;MultipleActiveResultSets=true");
            
            BackgroundJob.Enqueue(() => Console.WriteLine("Fire-and-forget"));

            var mc = new ModuleCatalog();
            //mc.AddModule<JobTest1.JobTest>(InitializationMode.WhenAvailable);

            Console.ReadLine();
			
        }
    }
}
