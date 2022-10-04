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
        public void UpdateOrder()
        {
            if (StartNode)
            {
                Order = 0;
                return;
            }

            int lowest = 999;
            foreach (var link in Links)
            {
                if (link.TargetNode is PowerNode)
                {
                    PowerNode node = (PowerNode)link.TargetNode;
                    if (node.Order < lowest)
                    {
                        lowest = node.Order;
                    }
                }
            }
            Order = lowest + 1;
        } 
    }
}
