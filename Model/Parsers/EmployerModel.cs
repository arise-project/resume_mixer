using System;

namespace resume_mixer.Models.Parser
{
    public struct EmployerModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        public string[] Projects { get; set; }

        public DateTime From { get; set; }

        public DateTime? To { get; set; }
    }
}
