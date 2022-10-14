using System;
using resume_mixer.Models.Parser;
using Microsoft.Extensions.Options;
using resume_mixer.Config;
using System.Collections.Generic;
using resume_mixer.Parser.Iterface;

namespace resume_mixer.Parser
{
    public class StackParser : IStackParser
    {
        readonly AppConfig options;
        public StackParser(IOptions<AppConfig> o)
        {
            options = o.Value;
        }

        public List<StackModel> Parse()
        {
            //key-list-key
            return null;
        }

        public void Parse(string fileName)
        {

        }
    }
}
