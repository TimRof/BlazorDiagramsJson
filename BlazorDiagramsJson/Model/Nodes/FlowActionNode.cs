using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;

namespace BlazorDiagramsJson.Model.Nodes
{
    public class FlowActionNode : NodeModel
    {
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
        private void Cancel(CancellationToken cancellationToken)
        {
            // Set status aborted + cleanup?
            cancellationToken.ThrowIfCancellationRequested();
        }
        public async Task ActivateAsync(CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                Cancel(cancellationToken);
                return;
            }

            SetActive();

            Action();
            await FindAndActivateNextNodeAsync(cancellationToken);

            SetFinished();
        }
        public virtual void Action()
        {
            // code / process to execute
        }
        public Task FindAndActivateNextNodeAsync(CancellationToken cancellationToken)
        {
            var task = Task.Run(() =>
            {
                foreach (var link in Links)
                {
                    if (cancellationToken.IsCancellationRequested)
                    {
                        Cancel(cancellationToken);
                        return;
                    }
                    if (link.TargetNode != null && link.TargetNode is FlowActionNode)
                    {
                        FlowActionNode flowActionNode = (FlowActionNode)link.TargetNode;
                        flowActionNode.ActivateAsync(cancellationToken);
                    }
                }
            });

            return Task.CompletedTask;
        }
    }
}
