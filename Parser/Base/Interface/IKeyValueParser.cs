using System.Collections.Generic;

namespace resume_mixer.Parser.Base.Interface
{
    public interface IKeyValueParser
    {
        public Dictionary<string, string> Parse(string fileName);
    }
}
