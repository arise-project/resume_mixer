using System.Collections.Generic;
namespace resume_mixer.Parser.Base.Interface
{
    public interface IKeyListParser
    {
        public Dictionary<string, List<string>> Parse(string fileName);
    }
}
