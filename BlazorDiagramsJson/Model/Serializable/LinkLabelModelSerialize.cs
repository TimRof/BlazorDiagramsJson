
using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models.Base;

namespace BlazorDiagramsJson.Model.Serializable
{
    public class LinkLabelModelSerialize
    {
        public LinkLabelModelSerialize(string parent, string id, string content, double? distance = null, Point? offset = null)
        {
            ParentNode = parent;
            Id = id;
            Content = content;
            Distance = distance;
            Offset = offset;
        }

        public LinkLabelModelSerialize(string parent, string content, double? distance = null, Point? offset = null)
        {
            ParentNode = parent;
            Content = content;
            Distance = distance;
            Offset = offset;
        }
        public string ParentNode { get; }
        public string? Id { get; }
        public string Content { get; set; }
        /// <summary>
        /// 3 types of values are possible:
        /// <para>- A number between 0 and 1: Position relative to the link's length</para>
        /// <para>- A positive number, greater than 1: Position away from the start</para>
        /// <para>- A negative number, less than 0: Position away from the end</para>
        /// </summary>
        public double? Distance { get; set; }
        public Point? Offset { get; set; }
    }
}
