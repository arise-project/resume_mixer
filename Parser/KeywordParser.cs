using System;
using resume_mixer.Models.Parser;
using Microsoft.Extensions.Options;
using resume_mixer.Config;

namespace resume_mixer.Parser
{
    public class KeywordParser
    {
        readonly AppConfig options;
        public KeywordParser(IOptions<AppConfig> o)
        {
            this.options = o.Value;
        }

        public KeywordModel Parse()
        {
            return null;
        }
    }
}
