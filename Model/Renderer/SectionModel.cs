using System;
using resume_mixer.Models.Parser;

namespace resume_mixer.Models.Renderer
{
    public class SectionModel
    {
        public EmployerModel Employer { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }

        public string Description { get; set; }

        public string[] Relations { get; set; }

        public string[] Language { get; set; }

        public string[] Architecture { get; set; }

        public string[] Stack { get; set; }

        public string[] Technology { get; set; }

        public string[] Environment { get; set; }
    }
}
