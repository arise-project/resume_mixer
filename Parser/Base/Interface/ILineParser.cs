using System.Collections.Generic;

namespace resume_mixer.Parser.Base
{
    public interface ILineParser
    {
        public List<string> Parse(string fileName);
    }
}
