using KonzolDesktopAdatbazisConsole.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonzolDesktopAdatbazisDesktop.ViewModel
{
    public class MainViewModel
    {
        private WorkerRepo repo = new WorkerRepo();
        public ControlPanelViewModel ControlPanelViewModel { get; set; }
        public WorkerApplicantManagmentViewModel WorkerApplicantManagmentViewModel { get; set; }

        public MainViewModel()
        {
            ControlPanelViewModel = new ControlPanelViewModel(repo);
            WorkerApplicantManagmentViewModel = new WorkerApplicantManagmentViewModel(repo);
        }
    }
}
