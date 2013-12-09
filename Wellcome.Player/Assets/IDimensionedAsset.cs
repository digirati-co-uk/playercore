namespace Wellcome.Player.Assets
{
    public interface IDimensionedAsset : IAsset
    {
        int Width { get; set; } 
        int Height { get; set; }
    }
}
