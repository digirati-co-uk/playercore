namespace Wellcome.Player
{
    public interface IStructure
    {
        string Name { get; set; }
        int? AssetSequence { get; set; }
        IStructure[] Structures { get; set; }
    }
}