using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;

namespace BlazorDiagramsJson.Model.Nodes
{
    public class FlowActionNode : NodeModel
    {
        // nodes data not updating unless clicked on
        public FlowActionNode(Point? position = null) : base(position)
        {
        }
        public FlowActionNode(string id, Point? position = null) : base(id, position)
        {
        }
        public bool Active { get; set; } = false; // status Active, Finished, Aborted
        public bool Finished { get; set; } = false;

        private void SetActive()
        {
            Active = true;
        }
        private void SetFinished()
        {
            Active = false;
            Finished = true;
        }
        public async Task ActivateAsync(string parentId)
        {
            SetActive();

            await ActionAsync();

            await FindAndActivateNextNodeAsync(parentId);

            SetFinished();
        }
        public virtual async Task ActionAsync()
        {
            // code / process to execute
        }
        public Task FindAndActivateNextNodeAsync(string parentId) // infinite loop now (get id from parent, check if not that)
        {
            var task = Task.Run(() =>
            {
                foreach (var port in Ports)
                {
                    foreach (var link in port.Links)
                    {
                        if (link.TargetNode != null && link.TargetNode is FlowActionNode && link.TargetNode.Id != parentId && link.TargetNode.Id != Id)
                        {
                            FlowActionNode flowActionNode = (FlowActionNode)link.TargetNode;
                            flowActionNode.ActivateAsync(Id);
                        }
                    }
                }
            });
            return Task.CompletedTask;
        }
    }
}
