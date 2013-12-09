namespace Wellcome.Player.Assets
{
    public interface IAsset
    {
        string Identifier { get; set; } 
        int Order { get; set; }
        string OrderLabel { get; set; }
        ISeeAlso SeeAlso { get; set; }
        string FileUri { get; set; }
    }
}
