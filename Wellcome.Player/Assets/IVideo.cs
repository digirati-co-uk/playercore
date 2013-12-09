namespace Wellcome.Player.Assets
{
    public interface IVideo : IDimensionedAsset
    {
        // this could be a better type - e.g., TimeSpan or oemthing a bit more numerical
        string Length { get; set; }
        IMediaSource[] Sources { get; set; }
    }
}
