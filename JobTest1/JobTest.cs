using Hangfire;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTest1
{
    public class JobTest : IModule
    {
        public void Initialize()
        {
            GlobalConfiguration.Configuration.UseSqlServerStorage("Data Source=DESKTOP-6V4JBGP\\SQL2008;Initial Catalog=HangFireDashBoard;Integrated Security=True");

            BackgroundJob.Enqueue(() => Console.WriteLine("Job Test MEF"));
        }
    }
}
