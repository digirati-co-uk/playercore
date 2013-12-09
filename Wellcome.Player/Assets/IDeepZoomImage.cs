using System;
using System.Collections.Generic;
using System.Text;

namespace Wellcome.Player.Assets
{
    public interface IDeepZoomImage : IDimensionedAsset
    {
        string NavigatorPath { get; set; }
        string ThumbnailPath { get; set; }
    }
}
