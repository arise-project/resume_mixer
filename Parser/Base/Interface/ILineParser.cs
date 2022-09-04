using System.Collections.Generic;

namespace resume_mixer.Parser.Base.Interface
{
    public interface ILineParser
    {
        public List<string> Parse(string fileName);
    }
}
