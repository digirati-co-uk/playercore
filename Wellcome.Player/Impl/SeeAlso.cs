using System;

namespace Wellcome.Player.Impl
{
    [Serializable]
    public class SeeAlso : ISeeAlso
    {
        public string Tag { get; set; }
        public string Uri { get; set; }
        public string Markup { get; set; }
        public object Data { get; set; }
    }
}