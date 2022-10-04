using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;
using System.Data;

namespace BlazorDiagramsJson.Model
{
    public abstract class CustomNode : NodeModel
    {
        public CustomNode(string? id = null, Point? position = null) : base(id, position)
        {
        }
        public CustomNode(Point? position = null) : base(position)
        {
        }
    }
}
