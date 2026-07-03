using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Enums;

namespace ConsoleApp1.Models
{
    public class Job
    {
        public int JobId { get; set; }

        public int CompanyId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public decimal Salary { get; set; }

        public JobType JobType { get; set; }

        public bool IsActive { get; set; }

        public DateTime PostedAt { get; set; }

        public Job()
        {
            Title = string.Empty;
            Description = string.Empty;
            Location = string.Empty;
            IsActive = true;
            PostedAt = DateTime.Now;
        }

        public Job(int companyId, string title, string description, string location, decimal salary, JobType jobType)
        {
            CompanyId = companyId;
            Title = title;
            Description = description;
            Location = location;
            Salary = salary;
            JobType = jobType;
            IsActive = true;
            PostedAt = DateTime.Now;
        }
    }
}

