using System;

namespace resume_mixer.Models.Parser
{
    public struct StackModel
    {
        public EmployerModel Employer { get; set; }
        public string[] Language { get; set; }
        public string[] Stack { get; set; }
        public string[] Technology { get; set; }
        public string[] Environment { get; set; }
        public string[] Archtecture { get; set; }
    }
}
