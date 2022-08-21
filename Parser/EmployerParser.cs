using System;
using resume_mixer.Models.Parser;
using Microsoft.Extensions.Options;
using resume_mixer.Config;

namespace resume_mixer.Parser
{
    public class EmployerParser
    {
        readonly AppConfig options;
        public EmployerParser(IOptions<AppConfig> o)
        {
            this.options = o.Value;
        }

        public EmployerModel Parse()
        {
            return null;
        }
    }
}
