using Blazor.Diagrams.Core.Models;

namespace BlazorDiagramsJson.Model.Serializable
{
    public class BaseLinkModelSerialize
    {
        public BaseLinkModelSerialize(string id, PortAlignment sourcePortAlignment, PortAlignment targetPortAlignment, string sourceNode, string? targetNode, string? sourcePort, string? targetPort)
        {
            Id = id;
            SourcePortAlignment = sourcePortAlignment;
            TargetPortAlignment = targetPortAlignment;
            SourceNode = sourceNode;
            TargetNode = targetNode;
        }

        public string? Id { get; set; }
        public PortAlignment SourcePortAlignment { get; set; }
        public PortAlignment TargetPortAlignment { get; set; }
        public string SourceNode { get; private set; }
        public string? TargetNode { get; private set; }
    }
}
