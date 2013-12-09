using System;

namespace Wellcome.Player.Impl
{
    [Serializable]
    public class Package : IPackage
    {
        public string Identifier { get; set; } 
        public string Status { get; set; }
        public IStructure RootStructure { get; set; }
        public IAssetSequence[] AssetSequences { get; set; }

        public string BibliographicInformation { get; set; }
    }
}
