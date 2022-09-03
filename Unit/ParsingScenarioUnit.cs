using System;
using Microsoft.Extensions.Options;
using resume_mixer.Config;
using resume_mixer.Unit.Interface;

namespace resume_mixer.Unit
{
    public class ParsingScenarioUnit : IParsingScenarioUnit
    {
        readonly AppConfig options;
        readonly Settings settings;
        public ParsingScenarioUnit(IOptions<AppConfig> o, Settings s)
        {
            options = o.Value;
            settings = s;
        }
        
        public void Run()
        {

        }
    }
}
