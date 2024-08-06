using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static WorkerOfCompany.ProjectManager;

namespace WorkerOfCompany
{
    public abstract class Workers // we created the abstract class 
    {
        // created the property for the abstarct method
        public  string Name { get; set; } // 
        public string Surname { get; set; }

        public string Department { get; set; }

        public abstract void job(string jobs); // created the abstarct method
        public void Info() // we optional create the cunstroctor method for the information
        {
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Surname:{Surname}");
            
            Console.WriteLine($"Departmant:{Department}");
        }

    }

    public class ProjectManager : Workers // we create the projectmanager class and we inherited the workers class
    {
        public override void job(string jobs) //  we overide job nethod for the PO
        {
            Console.WriteLine($"i am working to {jobs}");
        }

        public class SoftwareDeveloper : Workers// we create the softwaredeveloper class and we inherited the workers class
        {
            public override void job(string jobs) //  we overide job nethod for the Develpoer
            {
                Console.WriteLine($"i am working to {jobs}");
            }

        }
        public class Saler : Workers //we create the Saler class and we inherited the workers class
        {
            public override void job(string jobs) //  we overide job nethod for the Saler
            {
                Console.WriteLine($"i am working to {jobs}");
            }

        }
    }
}
