namespace Wellcome.Player.Assets
{
    public interface IDocument : IAsset
    {
        int NumberOfPages { get; set; }
    }
}
