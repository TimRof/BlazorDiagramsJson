using Blazor.Diagrams.Core;

namespace BlazorDiagramsJson.Model
{
    public class DefaultDiagramOptions
    {
        public DefaultDiagramOptions()
        {
            options = _options;
        }
        public DiagramOptions options { get; set; }

        private DiagramOptions _options = new DiagramOptions
        {
            DeleteKey = "Delete", // What key deletes the selected nodes/links
            DefaultNodeComponent = null, // Default component for nodes
            AllowMultiSelection = true, // Whether to allow multi selection using CTRL
            Zoom = new DiagramZoomOptions
            {
                Minimum = 0.5, // Minimum zoom value
                Inverse = true, // Whether to inverse the direction of the zoom when using the wheel
                                // Other
            },
            GridSize = 50,
            Links = new DiagramLinkOptions
            {
                EnableSnapping = true,
                DefaultRouter = new Router(Routers.Orthogonal),
                DefaultPathGenerator = PathGenerators.Straight
            }
        };
        public DiagramOptions GetDefaultOptions()
        {
            return options;
        }
    }
}
