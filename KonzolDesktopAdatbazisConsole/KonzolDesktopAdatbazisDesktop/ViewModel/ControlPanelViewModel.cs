using CommunityToolkit.Mvvm.ComponentModel;
using KonzolDesktopAdatbazisConsole.Repo;
using System.Collections.ObjectModel;

namespace KonzolDesktopAdatbazisDesktop.ViewModel
{
    public partial class ControlPanelViewModel : ObservableObject
    {
        private WorkerRepo _repo;

        [ObservableProperty]
        private string _numberOfApplicant = string.Empty;
        public ControlPanelViewModel(WorkerRepo repo)
        {
            _repo = repo;
            NumberOfApplicant = $"{_repo.GetNumberOfWorker()} fő";
        }
    }
}
