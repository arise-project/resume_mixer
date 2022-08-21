using System;
using resume_mixer.Models.Parser;
using Microsoft.Extensions.Options;
using resume_mixer.Config;

namespace resume_mixer.Parser
{
    public class PlatformParser
    {
        readonly AppConfig options;
        public PlatformParser(IOptions<AppConfig> o)
        {
            this.options = o.Value;
        }

        public StackModel Parse()
        {
            return null;
        }
    }
}
