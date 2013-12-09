namespace Wellcome.Player
{
    public interface IPackage
    {
        string Identifier { get; set; }
        string Status { get; set; }
        IAssetSequence[] AssetSequences { get; set; }
        IStructure RootStructure { get; set; }

        /// <summary>
        /// This is optional; player implementations may do with this what they see fit.
        /// For Wellcome it's a URI of a chunk of JSON that the Wellcome-custom player uses th generate the MORE INFO panel.
        /// But other implementations could use it to provide a link to a catalogue record only.
        /// </summary>
        string BibliographicInformation { get; set; }
    }
}
