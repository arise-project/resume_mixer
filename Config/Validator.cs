using Microsoft.Extensions.Options;

namespace resume_mixer.Config
{
    public class Validator
    {
        readonly AppConfig options;
        public Validator(IOptions<AppConfig> o)
        {
            this.options = o.Value;
        }

        public bool Validate()
        {
            return true;
        }
    }
}