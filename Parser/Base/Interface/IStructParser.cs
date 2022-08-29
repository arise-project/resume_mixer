using System.Collections.Generic;

namespace resume_mixer.Parser.Base
{
    public interface IStructParser<T>
    where T : struct
    {
        public List<T> Parse(string fileName);
    }
}
