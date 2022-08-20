using System;
using resume_mixer.Models.Parser;
using Microsoft.Extensions.Options;
using resume_mixer.Config;

namespace resume_mixer.Parser
{
    public class EmployerParser
    {
        public EmployerParser(IOptions<AppConfig> o)
        {

        }

        public EmployerModel Parse()
        {
            return null;
        }
    }
}
