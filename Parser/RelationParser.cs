using System;
using resume_mixer.Models.Parser;
using Microsoft.Extensions.Options;
using resume_mixer.Config;
using System.Collections.Generic;
using resume_mixer.Parser.Iterface;
using resume_mixer.Parser.Base.Interface;

namespace resume_mixer.Parser
{
    public class RelationParser : IRelationParser
    {
        readonly AppConfig options;
        private readonly IKeyListParser parser;

        public RelationParser(
            IOptions<AppConfig> o,
            IKeyListParser parser)
        {
            options = o.Value;
            this.parser = parser;
        }

        public List<RelationModel> Parse()
        {
            //key-list
            return null;
        }

        public void Assign(string fileName)
        {

        }
    }
}
