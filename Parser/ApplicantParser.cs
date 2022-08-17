using System;
using resume_mixer.Models.Parser;
using Microsoft.Extensions.Options;
using resume_mixer.Config;

namespace resume_mixer.Parser
{
    public class ApplicantParser
    {
        public ApplicantParser(IOptions<AppConfiguration> o)
        {

        }

        public ApplicantModel Parse()
        {
            return null;
        }
    }
}
