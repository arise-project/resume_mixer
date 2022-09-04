using System.Collections.Generic;

namespace resume_mixer.Parser.Base.Interface
{
    public interface IKeyMultiValueParser
    {
        public Dictionary<string, List<string>> Parse();
    }
}
