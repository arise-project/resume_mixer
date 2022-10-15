using System;
using resume_mixer.Models.Parser;
using Microsoft.Extensions.Options;
using resume_mixer.Config;
using System.Collections.Generic;
using resume_mixer.Parser.Iterface;
using resume_mixer.Parser.Base.Interface;

namespace resume_mixer.Parser
{
    public class ApplicantParser : IApplicantParser
    {
        readonly AppConfig options;
        private readonly IStructParser<ApplicantModel> parser;

        public ApplicantParser(
            IOptions<AppConfig> o,
            IStructParser<ApplicantModel> parser)
        {
            options = o.Value;
            this.parser = parser;
        }

        public List<ApplicantModel> Parse()
        {
            return null;
        }

        public void Assign(string fileName)
        {

        }
    }
}
