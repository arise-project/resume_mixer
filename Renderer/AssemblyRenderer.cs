using System;
using Microsoft.Extensions.Options;
using resume_mixer.Config;

namespace resume_mixer.Renderer
{
    public class AssemblyRenderer
    {
        readonly AppConfig options;
        public AssemblyRenderer(IOptions<AppConfig> o)
        {
            this.options = o.Value;
        }

        public void Render()
        {

        }
    }
}
