namespace Wellcome.Player
{
    public interface ISeeAlso
    {
        /// <summary>
        /// Idenitifier that allows the player to implement different seeAlso behaviour for different types of
        /// SeeAlso information. For example, in an MoH report the tag could be "moh", and the Player knows to 
        /// use the Data object to highlight tables. In a Project X b number the tag could be "projectX" and
        /// the Player invokes a different presentation.
        /// 
        /// A package can contain SeeAlso instances with different tags - the package might be an MoH report
        /// and an exhibit in Project X at the same time.
        /// </summary>
        string Tag { get; set; }

        /// <summary>
        /// This might be a link that the Player sends the user to via a hyperlink, or it might be a URI
        /// that a player extension fetches more data from. It can be used for many purposes.
        /// </summary>
        string Uri { get; set; }

        /// <summary>
        /// If the player is using the default SeeAlso implementation it will display the markup here
        /// </summary>
        string Markup { get; set; }

        /// <summary>
        /// Additional data the Player might wish to use, if it (or an extension) understands the tag
        /// </summary>
        object Data { get; set; }
    }
}
