using System;

namespace Wellcome.Player.Assets.Impl
{
    [Serializable]
    public class Document : IDocument
    {
        public string Identifier { get; set; }
        public int Order { get; set; }
        public string OrderLabel { get; set; }
        public int NumberOfPages { get; set; }
        public ISeeAlso SeeAlso { get; set; }
        public string FileUri { get; set; }
    }
}
