using Wellcome.Player.Assets;

namespace Wellcome.Player
{
    public interface IAssetSequence
    {
        bool IsUri();

        // these two are implied by container, but helpful here
        string PackageIdentifier { get; set; } // id of the containing package
        int Index { get; set; } // index within the list
        IAsset[] Assets { get; set; }
        int AssetCount { get; set; }
        ISection RootSection { get; set; }
        ISeeAlso SeeAlso { get; set; }
        bool SupportsSearch { get; set; }
        string AutoCompletePath { get; set; }

        // moved FROM IAsset. All assets in a sequence must be of the same type.
        string AssetType { get; set; }
    }
}
