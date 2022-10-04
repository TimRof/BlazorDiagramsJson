using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;

namespace BlazorDiagramsJson.Model.Nodes
{
    public class EndNode : NodeModel
    {
        public EndNode(Point? position = null) : base(position)
        {
        }
        public EndNode(string id, Point? position = null) : base(id, position)
        {
        }
    }
}
