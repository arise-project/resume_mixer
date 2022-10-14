using System;
using resume_mixer.Models.Parser;
using Microsoft.Extensions.Options;
using resume_mixer.Config;
using System.Collections.Generic;
using resume_mixer.Parser.Iterface;

namespace resume_mixer.Parser.Splitter.Interface
{
    public interface IEmptyLineSplitter
    {
        List<string> Split(string text);
    }
}
