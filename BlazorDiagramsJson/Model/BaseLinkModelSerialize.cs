using Blazor.Diagrams.Core.Models;

namespace BlazorDiagramsJson.Model
{
    public class BaseLinkModelSerialize
    {
        public BaseLinkModelSerialize(PortAlignment sourcePortAlignment, PortAlignment targetPortAlignment, string sourceNode, string? targetNode, string? sourcePort, string? targetPort)
        {
            SourcePortAlignment = sourcePortAlignment;
            TargetPortAlignment = targetPortAlignment;
            SourceNode = sourceNode;
            TargetNode = targetNode;
            SourcePort = sourcePort;
            TargetPort = targetPort;
        }
        public PortAlignment SourcePortAlignment { get; set; }
        public PortAlignment TargetPortAlignment { get; set; }
        public string SourceNode { get; private set; }

        public string? TargetNode { get; private set; }

        public string? SourcePort { get; private set; }

        public string? TargetPort { get; private set; }
    }
}
