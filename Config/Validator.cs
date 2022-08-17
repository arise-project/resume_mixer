using Microsoft.Extensions.Options;

namespace resume_mixer.Config
{
    public class Validator
    {
        public bool Validate(IOptions<AppConfiguration> options)
        {
            return true;
        }
    }
}