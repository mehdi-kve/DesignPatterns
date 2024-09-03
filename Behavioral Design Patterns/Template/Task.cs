using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public abstract class Task
    {
        private AuditTrail auditTrail;

        public Task()
        {
            auditTrail = new AuditTrail();
        }

        public void execute() 
        {
            auditTrail.record();
            doExecute();
        }

        protected abstract void doExecute();

    }
}
