using System.IO;
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
            var c = Directory.Exists(options.Commons);
            var f = !(string.IsNullOrWhiteSpace(options.CompanyId) ||
            string.IsNullOrWhiteSpace(options.CompanyName));
            var w = Directory.Exists(options.Worksapace);

            return c && w && f;
        }
    }
}