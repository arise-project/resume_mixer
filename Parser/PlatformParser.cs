using System;
using resume_mixer.Models.Parser;
using Microsoft.Extensions.Options;
using resume_mixer.Config;

namespace resume_mixer.Parser
{
    public class PlatformParser
    {
        public StackParser(IOptions<AppConfiguration> o)
        {

        }

        public StackModel Parse()
        {
            return null;
        }
    }
}
