using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;

namespace BlazorDiagramsJson.Model
{
    public class PortModelSerialize
    {
        public PortModelSerialize(string id, PortAlignment alignment)
        {
            Id = id;
            Alignment = alignment;
        }
        public string Id { get; set; }
        public PortAlignment Alignment { get; set; }
    }
}
