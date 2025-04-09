

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
        public decimal GetAvgOfSalary()
        {
            return _context.Workers
                .Average(s => s.Salary);
        }
        public string GetHighestPaidWorker()
        {
            return _context.Workers
                .OrderByDescending(s => s.Salary)
                .Select(s => s.Name)
                .First();

        }
        public string GetLowestPaidWorker()
        {
            return _context.Workers
                .OrderBy(s => s.Salary)
                .Select(s => s.Name)
                .First();
        }
        public Dictionary<string, int> GetDictionaryEmail()
        {
            var email = _context.Workers
                .Where(e => !string.IsNullOrEmpty(e.Email) && e.Email.Contains("@"));
            return _context.Workers
                .Where(e => !string.IsNullOrEmpty(e.Email) && e.Email.Contains("@"))
                .GroupBy(e => e.Email.Substring(e.Email.IndexOf('@') + 1))
                .ToDictionary(e => e.Key, e => e.Count());
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
