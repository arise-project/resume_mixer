using System;
using resume_mixer.Models.Parser;
using Microsoft.Extensions.Options;
using resume_mixer.Config;
using System.Collections.Generic;
using resume_mixer.Parser.Iterface;

namespace resume_mixer.Parser
{
    public class DescriptionParser : IDescriptionParser
    {
        readonly AppConfig options;
        public DescriptionParser(IOptions<AppConfig> o)
        {
            options = o.Value;
        }

        public List<DescriptionModel> Parse()
        {
            //key-value
            return null;
        }
    }
}
