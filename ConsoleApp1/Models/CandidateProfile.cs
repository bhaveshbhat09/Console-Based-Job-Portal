using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class CandidateProfile
    {
        public int ProfileId { get; set; }

        public int CandidateId { get; set; }

        public string Phone { get; set; }

        public string Skills { get; set; }

        public int ExperienceYears { get; set; }

        public string Education { get; set; }

        public string ResumePath { get; set; }

        public CandidateProfile()
        {
            Phone = string.Empty;
            Skills = string.Empty;
            Education = string.Empty;
            ResumePath = string.Empty;
        }

        public CandidateProfile(int candidateId, string phone, string skills, int experienceYears, string education, string resumePath)
        {
            CandidateId = candidateId;
            Phone = phone;
            Skills = skills;
            ExperienceYears = experienceYears;
            Education = education;
            ResumePath = resumePath;
            }
    }
}

