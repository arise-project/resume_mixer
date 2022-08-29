using System.Collections.Generic;

namespace resume_mixer.Parser.Base
{
    public interface IKeyValueParser
    {
        public Dictionary<string, string> Parse(string fileName);
    }
}
