using System;
using resume_mixer.Models.Parser;
using Microsoft.Extensions.Options;
using resume_mixer.Config;

namespace resume_mixer.Parser
{
    public class RelationParser
    {
        readonly AppConfig options;
        public RelationParser(IOptions<AppConfig> o)
        {
            this.options = o.Value;
        }

        public RelationModel Parse()
        {
            return null;
        }
    }
}
