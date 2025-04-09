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
        [ObservableProperty]
        private string _numberOfPayed = string.Empty;
        [ObservableProperty]
        private string _numberOfUnPayed = string.Empty;
        [ObservableProperty]
        private string _highestPaidWorker = string.Empty;
        [ObservableProperty]
        private string _lowestPaidWorker = string.Empty;
        [ObservableProperty]
        private string _avgOfSalary = string.Empty;
        [ObservableProperty]
        private string _dictionaryEmail = string.Empty;
        
        public ControlPanelViewModel(WorkerRepo repo)
        {
            _repo = repo;
            NumberOfApplicant = $"{_repo.GetNumberOfWorker()} fő";
            NumberOfPayed = $"{_repo.GetNumberOfSalared()} fő";
            NumberOfUnPayed =$"{_repo.GetNumberOfSalaryless()} fő";
            HighestPaidWorker = $"{_repo.GetHighestPaidWorker()}";
            LowestPaidWorker = $"{_repo.GetLowestPaidWorker()}"; 
            AvgOfSalary = $"{_repo.GetAvgOfSalary()} Ft";
            DictionaryEmail = $"{_repo.GetDictionaryEmail()}";
        }
    }
}
