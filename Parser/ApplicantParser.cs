using System;
using resume_mixer.Models.Parser;
using Microsoft.Extensions.Options;
using resume_mixer.Config;

namespace resume_mixer.Parser
{
    public class ApplicantParser
    {
        readonly AppConfig options;
        public ApplicantParser(IOptions<AppConfig> o)
        {
            this.options = o.Value;
        }

        public ApplicantModel Parse()
        {
            return null;
        }
    }
}
