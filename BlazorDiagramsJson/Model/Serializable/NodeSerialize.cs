using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;
using System.ComponentModel.Design.Serialization;

namespace BlazorDiagramsJson.Model.Serializable
{
    public class NodeSerialize
    {
        public NodeSerialize(string id, Type nodeType, List<PortModelSerialize> ports, Point position, string title)
        {
            Id = id;
            NodeType = nodeType;
            Ports = new List<PortModelSerialize>(ports);
            Position = position;
            Title = title;
        }
        public string Id { get; set; }
        public Type NodeType { get; set; } // maybe not needed
        public List<PortModelSerialize> Ports { get; set; }
        public Point Position { get; set; }
        public string Title { get; set; }
    }
}
