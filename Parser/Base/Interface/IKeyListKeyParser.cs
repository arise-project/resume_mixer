using System.Collections.Generic;

namespace resume_mixer.Parser.Base.Interface
{
    public interface IKeyListKeyParser
    {
        public Dictionary<string, Dictionary<string, List<string>>> Parse(string fileName);
    }
}
