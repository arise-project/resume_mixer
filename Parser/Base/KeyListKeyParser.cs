using System.Collections.Generic;
using resume_mixer.Parser.Base.Interface;

namespace resume_mixer.Parser.Base
{
    public class KeyListKeyParser : IKeyListKeyParser
    {
        const string delimiterKey = ':';
        const string delimiterValue = ':';

        public Dictionary<string, Dictionary<string, string>> Parse(string fileName)
        {
            var res = new Dictionary<string, Dictionary<string, string>>();
            var text = File.ReadAllLines(fileName).Where(l => !string.IsNullOrWhiteSpace(l));
            var key = "";
            var list = new List<string>();
            foreach (var line in text)
            {
                if(line.Contains(delimiterKey))
                {
                    if(!string.IsNullOrWhiteSpace(key))
                    {
                        if(res.ContainsKey(key))
                        {
                            res[key].AddRange(list);
                        }
                        else
                        {
                            res.Add(key,list);
                        }
                    }
                    var split = line.Split(delimiterKey);
                    key = split[0];
                    list = new List<string>();
                    list.AddRange(split[1].Split(delimiterValue));
                }
                else
                {
                    list.AddRange(line.Split(delimiterValue));
                }
            }
            if(!string.IsNullOrWhiteSpace(key))
            {
                if(res.ContainsKey(key))
                {
                    res[key].AddRange(list);
                }
                else
                {
                    res.Add(key,list);
                }
            }

            return res;
        }
    }
}
