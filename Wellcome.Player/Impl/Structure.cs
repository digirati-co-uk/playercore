using System;

namespace Wellcome.Player.Impl
{
    [Serializable]
    public class Structure : IStructure
    {
        public string Name { get; set; }
        public int? AssetSequence { get; set; }
        public IStructure[] Structures { get; set; }
        public ISeeAlso SeeAlso { get; set; }
    }
}
