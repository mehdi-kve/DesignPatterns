using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public class GenerateReportTask : Task
    {
        protected override void doExecute()
        {
            Console.WriteLine("Generating Report");
        }
    }
}
