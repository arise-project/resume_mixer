using System.Collections.Generic;

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
