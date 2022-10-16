using YamlDotNet.Serialization;

namespace resume_mixer.Config
{
    public class Settings
    {
        public Common Common {get;set;}
        
        public Parser Parser {get;set;}

        [YamlMember(Alias = "data-file", ApplyNamingConventions = false)]
        public DataFile DataFile {get;set;}
    }
}
