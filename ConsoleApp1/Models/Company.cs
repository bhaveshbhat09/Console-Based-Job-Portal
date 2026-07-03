using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class Company
    {
        public int CompanyId { get; set; }

        public int RecruiterId { get; set; }

        public string CompanyName { get; set; }

        public string Industry { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public Company()
        {
            CompanyName = string.Empty;
            Industry = string.Empty;
            Location = string.Empty;
            Description = string.Empty;
            CreatedAt = DateTime.Now;
        }

        public Company(int recruiterId, string companyName, string industry, string location, string description)
        {
            RecruiterId = recruiterId;
            CompanyName = companyName;
            Industry = industry;
            Location = location;
            Description = description;
            CreatedAt = DateTime.Now;
        }
    }
}

