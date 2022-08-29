using System.Collections.Generic;

namespace resume_mixer.Parser.Base
{
    public interface IKeyMultiValueParser
    {
        public Dictionary<string, List<string>> Parse();
    }
}
