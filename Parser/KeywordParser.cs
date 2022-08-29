using System;
using resume_mixer.Models.Parser;
using Microsoft.Extensions.Options;
using resume_mixer.Config;
using System.Collections.Generic;

namespace resume_mixer.Parser
{
    public class KeywordParser : IKeywordParser
    {
        readonly AppConfig options;
        public KeywordParser(IOptions<AppConfig> o)
        {
            this.options = o.Value;
        }

        public List<KeywordModel> Parse()
        {
            return null;
        }
    }
}
