using resume_mixer.Models.Parser;
using System.Collections.Generic;

namespace resume_mixer.Parser
{
    public interface IStackParser
    {
        List<StackModel> Parse();
    }
}
