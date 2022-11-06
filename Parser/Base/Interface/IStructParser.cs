using System.Collections.Generic;

namespace resume_mixer.Parser.Base.Interface
{
    public interface IStructParser<T>
    {
        public List<T> Parse(string fileName);
    }
}
