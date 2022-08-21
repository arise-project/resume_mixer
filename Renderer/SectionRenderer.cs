using System;
using Microsoft.Extensions.Options;
using resume_mixer.Config;

namespace resume_mixer.Renderer
{
    public class SectionRenderer
    {
        readonly AppConfig options;
        public SectionRenderer(IOptions<AppConfig> o)
        {
            this.options = o.Value;
        }
        
        public void Render()
        {

        }
    }
}
