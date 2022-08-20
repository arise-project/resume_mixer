using Microsoft.Extensions.Options;

namespace resume_mixer.Config
{
    public class Validator
    {
        public bool Validate(IOptions<AppConfig> options)
        {
            return true;
        }
    }
}