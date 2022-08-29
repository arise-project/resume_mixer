using System.Collections.Generic;

namespace resume_mixer.Parser.Base
{
    public interface IKeyListKeyParser
    {
        public Dictionary<string, Dictionary<string, string>> Parse(string fileName);
    }
}
