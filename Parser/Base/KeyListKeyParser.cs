using System.IO;
using System.Linq;
using System.Collections.Generic;
using resume_mixer.Parser.Base.Interface;

namespace resume_mixer.Parser.Base
{
    public class KeyListKeyParser : IKeyListKeyParser
    {
        const char delimiterKey = ':';
        const char delimiterValue = ',';

        public Dictionary<string, Dictionary<string, List<string>>> Parse(string fileName)
        {
            var res = new Dictionary<string, Dictionary<string, List<string>>>();
            var text = File.ReadAllLines(fileName).Where(l => !string.IsNullOrWhiteSpace(l));
            string key = "", subkey = "";
            var sub = new Dictionary<string, List<string>>();
            List<string> list = null;
            foreach (var line in text)
            {
                if(line.Contains(delimiterKey))
                {
                    if (line.TrimStart() == line)
                    {
                        if (!string.IsNullOrEmpty(key))
                        {
                            res.Add(key, sub);
                        }
                        key = line.Trim().TrimEnd(delimiterKey);
                        sub = new Dictionary<string, List<string>>();
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(subkey))
                        {
                            sub.Add(subkey, list);
                            res[key].Add(subkey, list);
                        }

                        subkey = line.Trim().TrimEnd(delimiterKey);
                        list = line[line.IndexOf(delimiterKey)..]
                                .Split(delimiterValue)
                                .ToList();
                    }
                }
                else
                {
                    list = list.Union(
                                    line[line.IndexOf(delimiterKey)..]
                                    .Split(delimiterValue))
                               .ToList();
                }
            }

            if (!res[key].ContainsKey(subkey))
            {
                res[key].Add(subkey, list);
            }

            return res;
        }
    }
}
