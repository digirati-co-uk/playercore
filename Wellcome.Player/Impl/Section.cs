using System;

namespace Wellcome.Player.Impl
{
    [Serializable]
    public class Section : ISection
    {
        public string Title { get; set; }
        public string SectionType { get; set; }
        public ISeeAlso SeeAlso { get; set; }
        public ISection[] Sections { get; set; }
        public int[] Assets { get; set; }
    }
}
