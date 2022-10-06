using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;

namespace BlazorDiagramsJson.Model.Nodes
{

    public class StartNode : FlowActionNode
    {
        public bool Running { get; set; }
        public StartNode(Point? position = null) : base(position)
        {
            Running = false;
        }
        public StartNode(string id, Point? position = null) : base(id, position)
        {
            Running = false;
        }
        public void Start()
        {
            Running = true;
        }
    }
}
