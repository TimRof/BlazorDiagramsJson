using Blazor.Diagrams.Components.Groups;
using Blazor.Diagrams.Core;
using Blazor.Diagrams.Core.Layers;

namespace BlazorDiagramsJson.Model
{
    public class DiagramSerialize
    {
        public DiagramSerialize(string id)
        {
            Id = id;
            Nodes = new List<NodeSerialize>();
            Links = new List<BaseLinkModelSerialize>();
        }
        public string Id { get; set; }
        public List<NodeSerialize> Nodes { get; set; }
        public List<BaseLinkModelSerialize> Links { get; set; }
        public void AddNode(NodeSerialize node)
        {
            Nodes.Add(node);
        }
        public void AddLink(BaseLinkModelSerialize link)
        {
            Links.Add(link);
        }
    }
}
