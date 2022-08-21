using System;
using resume_mixer.Models.Parser;
using Microsoft.Extensions.Options;
using resume_mixer.Config;

namespace resume_mixer.Parser
{
    public class StackParser
    {
        readonly AppConfig options;
        public StackParser(IOptions<AppConfig> o)
        {
            this.options = o.Value;
        }

        public StackModel Parse()
        {
            return null;
        }
    }
}
