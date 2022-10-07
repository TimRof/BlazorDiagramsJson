using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;

namespace BlazorDiagramsJson.Model.Nodes
{
    public class DataNode : FlowActionNode
    {
        public int Value { get; set; } = 0;
        public DataNode(Point? position = null) : base(position)
        {
        }
        public DataNode(string id, Point? position = null) : base(id, position)
        {
        }
        public override async Task ActionAsync()
        {
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(Title);
                Value++;
            }
        }
    }
}
