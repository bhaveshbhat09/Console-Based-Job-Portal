using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    internal class Company
    {
        public int CompanyId {  get; set; }
        public int RecruiterId { get; set; }
        public string CompanyName { get; set; }
        public string Industry {  get; set; }
        public string Location { get; set; }
        public string Description {  get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
