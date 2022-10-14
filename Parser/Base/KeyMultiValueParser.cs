using System.Collections.Generic;
using System.IO;
using System.Linq;
using resume_mixer.Parser.Base.Interface;

namespace resume_mixer.Parser.Base
{
    public class KeyMultiValueParser : IKeyMultiValueParser
    {
        const char delimiterKey = ':';
        const char delimiterValue = ',';

        public Dictionary<string, List<string>> Parse(string fileName)
        {
            var res = new Dictionary<string, List<string>>();
            var text = File.ReadAllLines(fileName).Where(l => !string.IsNullOrWhiteSpace(l));
            string key = "";
            var list = new List<string>();
            foreach (var line in text)
            {
                if (line.Contains(delimiterKey))
                {
                    if (!string.IsNullOrEmpty(key))
                    {
                        res.Add(key, list);
                    }
                    key = line.Trim().TrimEnd(delimiterKey);
                    list = line[line.IndexOf(delimiterKey)..]
                                .Split(delimiterValue)
                                .ToList();
                }
                else
                {
                    list = list.Union(
                                    line[line.IndexOf(delimiterKey)..]
                                    .Split(delimiterValue))
                               .ToList();
                }
            }

            if (!res.ContainsKey(key))
            {
                res.Add(key, list);
            }

            return res;
        }
    }
}
