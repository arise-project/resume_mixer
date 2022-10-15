using System;
using resume_mixer.Models.Parser;
using Microsoft.Extensions.Options;
using resume_mixer.Config;
using System.Collections.Generic;
using resume_mixer.Parser.Iterface;
using resume_mixer.Parser.Base.Interface;

namespace resume_mixer.Parser
{
    public class DescriptionParser : IDescriptionParser
    {
        readonly AppConfig options;
        private readonly IKeyValueParser parser;

        public DescriptionParser(
            IOptions<AppConfig> o,
            IKeyValueParser parser)
        {
            options = o.Value;
            this.parser = parser;
        }

        public List<DescriptionModel> Parse()
        {
            //key-value
            return null;
        }

        public void Assign(string fileName)
        {

        }
    }
}
