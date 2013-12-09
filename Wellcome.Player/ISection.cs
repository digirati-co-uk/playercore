namespace Wellcome.Player
{
    public interface ISection
    {
        string Title { get; set; }
        string SectionType { get; set; }
        ISection[] Sections { get; set; }
        int[] Assets { get; set; }
        ISeeAlso SeeAlso { get; set; }
    }
}