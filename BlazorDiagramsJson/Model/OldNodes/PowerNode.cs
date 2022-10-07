using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;

namespace BlazorDiagramsJson.Model.OldNodes
{
    public class PowerNode : NodeModel
    {
        public PowerNode(Point? position = null) : base(position)
        {
            HasPower = false;
            StartNode = false;
            Order = -1;
        }
        public PowerNode(string id, Point? position = null) : base(id, position)
        {
            HasPower = false;
            StartNode = false;
            Order = -1;
        }

        public bool StartNode { get; set; }
        public bool HasPower { get; set; }
        public bool PowerConnected { get; set; }
        public int Order { get; set; }
        public void TurnOn()
        {
            HasPower = true;
        }
        public void TurnOff()
        {
            HasPower = false;
        }
    }
}
