using ConsoleApp1.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class JobApplication
    {
        public int ApplicationId { get; set; }

        public int JobId { get; set; }

        public int CandidateId { get; set; }

        public ApplicationStatus Status { get; set; }

        public DateTime AppliedAt { get; set; }

        public JobApplication()
        {
            Status = ApplicationStatus.Applied;
            AppliedAt = DateTime.Now;
        }

        public JobApplication(int jobId, int candidateId)
        {
            JobId = jobId;
            CandidateId = candidateId;
            Status = ApplicationStatus.Applied;
            AppliedAt = DateTime.Now;
        }
    }
}
