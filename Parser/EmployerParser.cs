using System;
using resume_mixer.Models.Parser;
using Microsoft.Extensions.Options;
using resume_mixer.Config;
using System.Collections.Generic;
using resume_mixer.Parser.Iterface;

namespace resume_mixer.Parser
{
    public class EmployerParser : IEmployerParser
    {
        readonly AppConfig options;
        public EmployerParser(IOptions<AppConfig> o)
        {
            options = o.Value;
        }

        public List<EmployerModel> Parse()
        {
            return null;
        }
    }
}
