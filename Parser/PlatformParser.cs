using System;
using resume_mixer.Models.Parser;
using Microsoft.Extensions.Options;
using resume_mixer.Config;

namespace resume_mixer.Parser
{
    public class PlatformParser
    {
        public PlatformParser(IOptions<AppConfig> o)
        {

        }

        public StackModel Parse()
        {
            return null;
        }
    }
}
