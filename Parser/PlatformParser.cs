using System;
using resume_mixer.Models.Parser;
using Microsoft.Extensions.Options;
using resume_mixer.Config;
using System.Collections.Generic;
using resume_mixer.Parser.Iterface;
using resume_mixer.Parser.Base.Interface;

namespace resume_mixer.Parser
{
    public class PlatformParser  : IPlatformParser
    {
        readonly AppConfig options;
        private readonly IKeyMultiValueParser parer;

        public PlatformParser(
            IOptions<AppConfig> o,
            IKeyMultiValueParser parer)
        {
            options = o.Value;
            this.parer = parer;
        }

        public List<StackModel> Parse()
        {
            //key-multi-value
            return null;
        }

        public void Assign(string fileName)
        {

        }
    }
}
