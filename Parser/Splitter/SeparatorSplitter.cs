using System;
using resume_mixer.Models.Parser;
using Microsoft.Extensions.Options;
using resume_mixer.Config;
using System.Collections.Generic;
using resume_mixer.Parser.Splitter.Interface;

namespace resume_mixer.Parser.Splitter
{
    public class SeparatorSplitter : ISeparatorSplitter
    {
        readonly AppConfig options;
        public SeparatorSplitter(IOptions<AppConfig> o)
        {
            options = o.Value;
        }

        public List<string> Split(string text)
        {
            return null;
        }
    }
}
