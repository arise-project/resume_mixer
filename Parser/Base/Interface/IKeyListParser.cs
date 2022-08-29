using System.Collections.Generic;
namespace resume_mixer.Parser.Base
{
    public interface IKeyListParser
    {
        public Dictionary<string, List<string>> Parse(string fileName);
    }
}
