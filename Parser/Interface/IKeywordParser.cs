using resume_mixer.Models.Parser;
using System.Collections.Generic;

namespace resume_mixer.Parser.Iterface
{
    public interface IKeywordParser : IFileParser
    {
        List<KeywordModel> Parse();
    }
}
