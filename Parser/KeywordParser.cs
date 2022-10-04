using System;
using resume_mixer.Models.Parser;
using Microsoft.Extensions.Options;
using resume_mixer.Config;
using System.Collections.Generic;
using resume_mixer.Parser.Iterface;

namespace resume_mixer.Parser
{
    public class KeywordParser : IKeywordParser
    {
        readonly AppConfig options;
        public KeywordParser(IOptions<AppConfig> o)
        {
            options = o.Value;
        }

        public List<KeywordModel> Parse()
        {
            //key-multi-value
            return null;
        }
    }
}
