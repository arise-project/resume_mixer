using System;
using resume_mixer.Models.Parser;
using Microsoft.Extensions.Options;
using resume_mixer.Config;

namespace resume_mixer.Parser
{
    public class DescriptionParser
    {
        readonly AppConfig options;
        public DescriptionParser(IOptions<AppConfig> o)
        {
            this.options = o.Value;
        }

        public DescriptionModel Parse()
        {
            return null;
        }
    }
}
