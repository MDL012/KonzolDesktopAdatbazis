﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonzolDesktopAdatbazisConsole.Model
{
    public class WorkerApplicant
    {
        private int _salary;
        private string _email;

        public WorkerApplicant(string name, string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentNullException("email");
            }
            if (!email.Contains('@'))
            {
                throw new ArgumentOutOfRangeException("email");
            }
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name");
            }
            Name = name;
            _email = email;
            _salary = 0;
        }
        public string? Name { get; set; }
        public string? Email { get => _email; set => _email = value; }
        public int? Salary { get => _salary; set => _salary = (int)value; }

        public void AddMoney(int salary)
        {
            if(salary <= 0)
            {
                throw new ArgumentNullException(nameof(salary));
            }
            _salary += salary;
        }

        public override string ToString()
        {
            return $"{Name} ({_email}) {_salary}Ft";
        }
    }
}