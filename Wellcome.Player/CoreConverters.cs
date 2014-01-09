namespace Wellcome.Player
{
    public static class CoreConverters
    {
        // convert package to just core
        public static Impl.Package ToCore(this IPackage package)
        {
            var corePackage = new Impl.Package
            {
                Identifier = package.Identifier,
                Status = package.Status,
                AssetSequences = package.AssetSequences,
                RootStructure = ToCore(package.RootStructure),
                BibliographicInformation = package.BibliographicInformation
            };
            if (corePackage.AssetSequences != null)
            {
                for (int i = 0; i < corePackage.AssetSequences.Length; i++)
                {
                    corePackage.AssetSequences[i] = ToCore(corePackage.AssetSequences[i]);
                }
            }
            return corePackage;
        }

        public static Impl.Structure ToCore(this IStructure structure)
        {
            if (structure == null) return null;
            var coreStructure = new Impl.Structure
            {
                AssetSequence = structure.AssetSequence,
                Name = structure.Name,
                Structures = structure.Structures,
                SeeAlso = structure.SeeAlso
            };
            if (coreStructure.Structures != null)
            {
                for (int i = 0; i < coreStructure.Structures.Length; i++)
                {
                    coreStructure.Structures[i] = ToCore(coreStructure.Structures[i]);
                }
            }
            return coreStructure;
        }

        public static Impl.Section ToCore(this ISection section)
        {
            if (section == null) return null;
            var coreSection = new Impl.Section
            {
                Assets = section.Assets,
                Sections = section.Sections,
                SectionType = section.SectionType,
                SeeAlso = section.SeeAlso,
                Title = section.Title
            };
            if (coreSection.Sections != null)
            {
                for (int i = 0; i < coreSection.Sections.Length; i++)
                {
                    coreSection.Sections[i] = ToCore(coreSection.Sections[i]);
                }
            }
            return coreSection;
        }

        // this can't be Player.Impl.AssetSequence because of the first line
        public static IAssetSequence ToCore(this IAssetSequence assetSequence)
        {
            if (assetSequence.IsUri()) return assetSequence;

            var coreSequence = new Impl.AssetSequence
            {
                AssetCount = assetSequence.AssetCount,
                Assets = assetSequence.Assets,
                AutoCompletePath = assetSequence.AutoCompletePath,
                Index = assetSequence.Index,
                PackageIdentifier = assetSequence.PackageIdentifier,
                RootSection = ToCore(assetSequence.RootSection),
                SeeAlso = assetSequence.SeeAlso,
                SupportsSearch = assetSequence.SupportsSearch,
                AssetType = assetSequence.AssetType
            };
            if (coreSequence.Assets != null)
            {
                for (int i = 0; i < coreSequence.Assets.Length; i++)
                {
                    coreSequence.Assets[i] = ToCore(coreSequence.Assets[i]);
                }
            }
            return coreSequence;
        }

        public static Assets.IAsset ToCore(this Assets.IAsset asset)
        {
            Assets.IAsset coreAsset = null;

            var audioAsset = asset as Assets.IAudio;
            if (audioAsset != null)
            {
                coreAsset = new Assets.Impl.Audio
                {
                    Length = audioAsset.Length
                };
            }

            var docAsset = asset as Assets.IDocument;
            if (docAsset != null)
            {
                coreAsset = new Assets.Impl.Document
                {
                    NumberOfPages = docAsset.NumberOfPages
                };
            }

            var videoAsset = asset as Assets.IVideo;
            if (videoAsset != null)
            {
                coreAsset = new Assets.Impl.Video
                {
                    Width = videoAsset.Width,
                    Height = videoAsset.Height,
                    Length = videoAsset.Length
                };
            }

            var dziAsset = asset as Assets.ISeadragonDeepZoomImage;
            if (dziAsset != null)
            {
                coreAsset = new Assets.Impl.SeadragonDeepZoomImage
                {
                    DziUri = dziAsset.DziUri,
                    Width = dziAsset.Width,
                    Height = dziAsset.Height,
                    NavigatorPath = dziAsset.NavigatorPath,
                    ThumbnailPath = dziAsset.ThumbnailPath
                };
            }

            // common
            if (coreAsset != null)
            {
                // moved to IAssetSequence coreAsset.AssetType = asset.AssetType;
                coreAsset.FileUri = asset.FileUri;
                coreAsset.Identifier = asset.Identifier;
                coreAsset.Order = asset.Order;
                coreAsset.OrderLabel = asset.OrderLabel;
                coreAsset.SeeAlso = asset.SeeAlso;
            }
            return coreAsset;
        }

    }
}
