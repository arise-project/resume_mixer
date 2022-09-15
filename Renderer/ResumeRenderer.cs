using System;
using Microsoft.Extensions.Options;
using resume_mixer.Config;
using resume_mixer.Renderer.Interface;

namespace resume_mixer.Renderer
{
    public class ResumeRenderer : IResumeRenderer
    {
        readonly AppConfig options;
        public ResumeRenderer(IOptions<AppConfig> o)
        {
            options = o.Value;
        }
        
        public void Render()
        {

        }
    }
}
