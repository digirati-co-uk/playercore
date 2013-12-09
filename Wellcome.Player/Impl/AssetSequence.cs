using System;
using Wellcome.Player.Assets;

namespace Wellcome.Player.Impl
{
    [Serializable]
    public class AssetSequence : IAssetSequence
    {
        public virtual bool IsUri()
        {
            return false;
        }
        
        public string PackageIdentifier { get; set; } // id of the containing package
        public int Index { get; set; }
        public string AssetType { get; set; }
        public int AssetCount { get; set; }
        public bool SupportsSearch { get; set; }
        public string AutoCompletePath { get; set; }
        public ISection RootSection { get; set; }
        public ISeeAlso SeeAlso { get; set; }
        public IAsset[] Assets { get; set; } 
    }
}
