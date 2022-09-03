using System;
using resume_mixer.Models.Parser;
using Microsoft.Extensions.Options;
using resume_mixer.Config;
using System.Collections.Generic;

namespace resume_mixer.Parser
{
    public class ApplicantParser : IApplicantParser
    {
        readonly AppConfig options;
        public ApplicantParser(IOptions<AppConfig> o)
        {
            options = o.Value;
        }

        public List<ApplicantModel> Parse()
        {
            return null;
        }
    }
}
