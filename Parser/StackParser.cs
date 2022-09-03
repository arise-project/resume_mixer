using System;
using resume_mixer.Models.Parser;
using Microsoft.Extensions.Options;
using resume_mixer.Config;
using System.Collections.Generic;

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
            return null;
        }
    }
}
