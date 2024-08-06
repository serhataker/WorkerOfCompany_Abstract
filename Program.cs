using System;
using WorkerOfCompany;
using static WorkerOfCompany.ProjectManager;

namespace Worker
{
    class WorkersCompany
    {


        static void Main(string[] args)
        {
            Workers projectManager = new ProjectManager();// we created instance projectmanager we can't the workers abstarct class but we can do it ProjectManager

            projectManager.job("Software PM");//we call the from the aabstract method implemneting method.
            //information property inpu for the PM object
            projectManager.Name = "Hakan";
            projectManager.Surname = "Mir";
            projectManager.Department = "Project";
            projectManager.Info();// call the constructor gived the by property

            Workers softwareDev = new SoftwareDeveloper{ Department = "Developer", Name = "Hasan", Surname = "Hayır" // another implemneting class process
            };
            softwareDev.job("Developer");
            softwareDev.Info();

            Workers saler = new Saler { Department = "Sales", Surname = "Ogeday", Name = "Çınar" }; // another implementing class process
            saler.job("Saler");
            saler.Info();
        }
    }

}