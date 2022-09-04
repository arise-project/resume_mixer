using System.Collections.Generic;
using resume_mixer.Parser.Base.Interface;

namespace resume_mixer.Parser.Base
{
    public class StructParser<T> : IStructParser<T>
    where T : struct
    {
        public List<T> Parse(string fileName)
        {
            return null;
        }
    }
}
