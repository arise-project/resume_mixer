using System;
using resume_mixer.Models.Parser;
using Microsoft.Extensions.Options;
using resume_mixer.Config;
using System.Collections.Generic;
using resume_mixer.Parser.Iterface;
using resume_mixer.Parser.Base.Interface;

namespace resume_mixer.Parser
{
    public class StackParser : IStackParser
    {
        readonly AppConfig options;
        private readonly IKeyListKeyParser parser;

        public StackParser(
            IOptions<AppConfig> o,
            IKeyListKeyParser parser)
        {
            options = o.Value;
            this.parser = parser;
        }

        public List<StackModel> Parse()
        {
            //key-list-key
            return null;
        }

        public void Assign(string fileName)
        {

        }
    }
}
