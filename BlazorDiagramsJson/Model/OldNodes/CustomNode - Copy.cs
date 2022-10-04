using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;

namespace BlazorDiagramsJson.Model
{
    public class CustomNodeCopy : CustomNode
    {
        // fix port alignment
        // fix link pathing
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public CustomNodeCopy(Point? position = null) : base(position)
        {
            FirstNumber = 0;
            SecondNumber = 0;
        }
        public CustomNodeCopy(string? id = null, Point? position = null) : base(id, position)
        {
            FirstNumber = 0;
            SecondNumber = 0;
        }

        public double Calculate()
        {
            return FirstNumber + SecondNumber;
        }
    }
}
