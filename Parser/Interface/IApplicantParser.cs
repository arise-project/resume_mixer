using resume_mixer.Models.Parser;
using System.Collections.Generic;

namespace resume_mixer.Parser.Iterface
{
    public interface IApplicantParser : IFileParser
    {
        List<ApplicantModel> Parse();
    }
}
