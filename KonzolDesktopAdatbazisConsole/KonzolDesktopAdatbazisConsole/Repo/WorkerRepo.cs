

using KonzolDesktopAdatbazisConsole.DBModel;
using KonzolDesktopAdatbazisConsole.Model;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System.Linq;

namespace KonzolDesktopAdatbazisConsole.Repo
{
    public class WorkerRepo
    {
        private readonly WorkerContext _context = new WorkerContext();
        public List<WorkerApplicant> GetAll()
        {
            return _context.Workers.ToList();
        }

        public int GetNumberOfWorker()
        {
            return _context.Workers.Count();
        }

        public int GetNumberOfSalaryless()
        {
            return _context.Workers
                .Where(s => s.Salary == 0)
                .Count();
        }
        public int GetNumberOfSalared()
        {
            return _context.Workers
                .Where(s => s.Salary > 0)
                .Count();
        }
        public decimal AvgOfSalary()
        {
            return _context.Workers
                .Average(s => s.Salary);
        }
        public string HighestPaidWorker()
        {
            return _context.Workers
                .OrderByDescending(s => s.Salary)
                .FirstOrDefault().Name;
        }
        public string LowestPaidWorker()
        {
            return _context.Workers
                .OrderBy(s => s.Salary)
                .FirstOrDefault().Name;
        }

        public void removeWorker(string email)
        {
            WorkerApplicant? found = _context.Workers.FirstOrDefault(s => s.Email == email);
            if (found == null)
                return;

            _context.Workers.Remove(found);
            _context.SaveChanges();
        }
    }
}
