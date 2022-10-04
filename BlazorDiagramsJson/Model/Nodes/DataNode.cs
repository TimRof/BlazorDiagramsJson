using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;

namespace BlazorDiagramsJson.Model.Nodes
{
    public class DataNode : NodeModel
    {
        public DataNode(Point? position = null) : base(position)
        {
        }
        public DataNode(string id, Point? position = null) : base(id, position)
        {
        }
    }
}
