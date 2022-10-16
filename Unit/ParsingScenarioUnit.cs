using System;
using System.Collections.Generic;
using Microsoft.Extensions.Options;
using resume_mixer.Config;
using resume_mixer.Unit.Interface;
using resume_mixer.Parser.Iterface;

namespace resume_mixer.Unit
{
    public class ParsingScenarioUnit : IParsingScenarioUnit
    {
        readonly AppConfig options;
        readonly Settings settings;
        readonly List<IFileParser> parsers = new List<IFileParser>();

        public ParsingScenarioUnit(
            IOptions<AppConfig> o, 
            Settings s,
            IApplicantParser applicantParser,
            IDescriptionParser descriptionParser,
            IEmployerParser employerParser,
            IKeywordParser keywordParser,
            IPlatformParser platformParser,
            IRelationParser relationParser,
            IStackParser stackParser
            )
        {
            options = o.Value;
            settings = s;

            if(settings.Parser.Architecture)
            {

            }
            if(settings.Parser.Description)
            {
                parsers.Add(descriptionParser);
            }
            if(settings.Parser.Employer)
            {
                parsers.Add(employerParser);
            }
            if(settings.Parser.Environment)
            {

            }
            if(settings.Parser.Language)
            {

            }
            if(settings.Parser.Relations)
            {
                parsers.Add(relationParser);
            }
            if(settings.Parser.Stack)
            {
                parsers.Add(stackParser);
            }
            if(settings.Parser.Technology)
            {

            }
        }
        
        public void Run()
        {
            //M982 Excalibur
            foreach(var parser in parsers)
            {
                parser.Assign();
            }
        }
    }
}
