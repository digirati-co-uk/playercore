using System;

namespace Wellcome.Player.Assets.Impl
{
    [Serializable]
    public class Video : IVideo
    {
        public string Identifier { get; set; }
        public int Order { get; set; }
        public string OrderLabel { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Length { get; set; }
        public ISeeAlso SeeAlso { get; set; }
        public string FileUri { get; set; }
        public IMediaSource[] Sources { get; set; }
    }
}
