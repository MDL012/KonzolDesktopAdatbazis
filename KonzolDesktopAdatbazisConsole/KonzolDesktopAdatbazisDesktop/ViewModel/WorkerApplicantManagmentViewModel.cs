using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KonzolDesktopAdatbazisConsole.DBModel;
using KonzolDesktopAdatbazisConsole.Model;
using KonzolDesktopAdatbazisConsole.Repo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonzolDesktopAdatbazisDesktop.ViewModel
{
    public partial class WorkerApplicantManagmentViewModel : ObservableObject
    {
        private WorkerRepo _repo;
        [ObservableProperty] private ObservableCollection<WorkerApplicant> _workers;
        [ObservableProperty] private WorkerApplicant _selected;
        [ObservableProperty] private string _solary;
        public WorkerApplicantManagmentViewModel(WorkerRepo repo)
        {
            _repo = repo;
            Workers = new ObservableCollection<WorkerApplicant>(_repo.GetAll());
        }

        [RelayCommand]
        public void Delet()
        {
            _repo.removeWorker(Selected.Email);
            Workers = new ObservableCollection<WorkerApplicant>(_repo.GetAll());
        }
    }
}
