using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Wellcome.Player;
using Wellcome.Player.Assets.Impl;
using Wellcome.Player.Impl;

namespace playercore.Controllers
{
    public class SamplesController : ApiController
    {
        public IPackage Get(string identifier)
        {
            IPackage package = null;
            switch(identifier)
            {
                case "fig1":
                    package = GetFig1("fig1");
                    break;
                case "fig2":
                    package = GetFig1("fig2");
                    AddFig2(package);
                    break;
            }
            return package;
        }

        private IPackage GetFig1(string identifier)
        {
            var package = BasePackage(identifier);
            var assets = new List<SeadragonDeepZoomImage>();
            for (int i = 0; i < 3; i++)
            {
                assets.Add(GetImage(identifier, i));
            }
            package.AssetSequences[0].Assets = assets.ToArray();
            return package;
        }

        private void AddFig2(IPackage package)
        {
            var rootSection = new Section()
            {
                Assets = new[] { 0, 1, 2 },
                SectionType = "Archive",
                Title = "Great Expectations"
            };
            package.AssetSequences[0].RootSection = rootSection;
            rootSection.Sections = new[] { new Section() { Title = "Table of Contents", SectionType = "TableOfContents", Assets = new[] { 1 } } };
        }

        private static Package BasePackage(string identifier)
        {
            var package = new Package();
            package.Identifier = identifier;
            package.AssetSequences = new AssetSequence[] { new AssetSequence() };
            package.AssetSequences[0].AssetType = "seadragon/dzi";
            package.AssetSequences[0].PackageIdentifier = identifier;
            package.AssetSequences[0].Index = 0;
            return package;
        }

        private SeadragonDeepZoomImage GetImage(string packageidentifier, int order)
        {
            var img = new SeadragonDeepZoomImage();
            img.DziUri = String.Format("/samples/{0}/img{1:D3}.dzi", packageidentifier, order);
            img.Width = 2000;
            img.Height = 3000;
            img.Identifier = Guid.NewGuid().ToString().Substring(0,6);
            img.Order = order;
            img.OrderLabel = order < 2 ? " - " : "page " + (order - 1);
            img.ThumbnailPath = String.Format("/thumbs/{0}/thumb{1:D3}.jpg", packageidentifier, order);
            return img;
        }
    }
}
