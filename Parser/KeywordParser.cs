using System;
using resume_mixer.Models.Parser;
using Microsoft.Extensions.Options;
using resume_mixer.Config;
using System.Collections.Generic;
using resume_mixer.Parser.Iterface;
using resume_mixer.Parser.Base.Interface;

namespace resume_mixer.Parser
{
    public class KeywordParser : IKeywordParser
    {
        readonly AppConfig options;
        private readonly IKeyMultiValueParser parser;

        public KeywordParser(
            IOptions<AppConfig> o,
            IKeyMultiValueParser parser)
        {
            options = o.Value;
            this.parser = parser;
        }

        public List<KeywordModel> Parse()
        {
            //key-multi-value
            return null;
        }

        public void Assign(string fileName)
        {

        }
    }
}
