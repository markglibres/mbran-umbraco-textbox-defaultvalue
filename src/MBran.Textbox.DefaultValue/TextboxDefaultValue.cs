using System.Runtime.Serialization;

namespace MBran.Textbox.DefaultValue
{
    [DataContract]
    public class TextboxDefaultValue
    {
        [DataMember(Name = "default")]
        public string Default { get; set; }

        [DataMember(Name = "text")]
        public string Value { get; set; }
    }
}