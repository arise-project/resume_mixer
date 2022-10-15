using System;
using resume_mixer.Models.Parser;
using Microsoft.Extensions.Options;
using resume_mixer.Config;
using System.Collections.Generic;
using resume_mixer.Parser.Iterface;
using resume_mixer.Parser.Base.Interface;

namespace resume_mixer.Parser
{
    public class EmployerParser : IEmployerParser
    {
        readonly AppConfig options;
        private readonly IStructParser<EmployerModel> parser;

        public EmployerParser(
            IOptions<AppConfig> o,
            IStructParser<EmployerModel> parser)
        {
            options = o.Value;
            this.parser = parser;
        }

        public List<EmployerModel> Parse()
        {
            //struct
            return null;
        }

        public void Assign(string fileName)
        {

        }
    }
}
