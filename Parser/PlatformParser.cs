using System;
using resume_mixer.Models.Parser;
using Microsoft.Extensions.Options;
using resume_mixer.Config;
using System.Collections.Generic;
using resume_mixer.Parser.Iterface;

namespace resume_mixer.Parser
{
    public class PlatformParser  : IPlatformParser
    {
        readonly AppConfig options;
        public PlatformParser(IOptions<AppConfig> o)
        {
            options = o.Value;
        }

        public List<StackModel> Parse()
        {
            return null;
        }
    }
}
