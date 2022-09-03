using Microsoft.Extensions.Options;
using resume_mixer.Config;

namespace resume_mixer.Unit
{
    public class RendererScenarioUnit
    {
        readonly AppConfig options;
        readonly Settings settings;
        public RendererScenarioUnit(IOptions<AppConfig> o, Settings s)
        {
            options = o.Value;
            settings = s;
        }
        
        public void Run()
        {

        }
    }
}
