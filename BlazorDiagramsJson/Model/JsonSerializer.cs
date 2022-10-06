using Blazor.Diagrams.Core;
using Blazor.Diagrams.Core.Models;
using BlazorDiagramsJson.Model.Serializable;
using Newtonsoft.Json;
using System.Data;
using System.Runtime.CompilerServices;

namespace BlazorDiagramsJson.Model
{
    public class JsonSerializer
    {
        private string fileName = "SavedDiagram-" + DateTime.Now.ToString("yyyy-M-dd--HH-mm-ss") + ".json";
        private readonly JsonSerializerSettings _options
            = new()
            {
                NullValueHandling = NullValueHandling.Ignore,
                TypeNameHandling = TypeNameHandling.Objects, // For custom Nodes?
                TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple
            };
        public DiagramSerialize GetSerializedFromDiagram(Diagram obj)
        {
            DiagramSerialize diagram = new(obj.Id);
            List<PortModelSerialize> ports = new();

            // get nodes
            foreach (var node in obj.Nodes)
            {
                foreach (var port in node.Ports)
                {
                    ports.Add(new PortModelSerialize(port.Id, port.Alignment));
                }
                diagram.AddNode(new NodeSerialize(node.Id, node.GetType(),ports, node.Position, node.Title));
                ports.Clear();
            }

            // get links
            foreach (var link in obj.Links)
            {
                diagram.AddLink(new BaseLinkModelSerialize(link.Id, link.SourcePort.Alignment, link.TargetPort.Alignment, link.SourceNode.Id, link.TargetNode.Id, link.SourcePort.Id, link.TargetPort.Id));
            }
            return diagram;
        }
        public string WriteToJson(Diagram obj)
        {
            var jsonString = JsonConvert.SerializeObject(GetSerializedFromDiagram(obj), Formatting.Indented, _options);
            return jsonString;
        }
        public string WriteToFile(Diagram obj)
        {
            string json = WriteToJson(obj);
            File.WriteAllText(fileName, json);
            return json;
        }
        public DiagramSerialize ReadDiagramFromJson(string json)
        {
            if (!String.IsNullOrEmpty(json))
            {
                return JsonConvert.DeserializeObject<DiagramSerialize>(json, _options);
            }
            return null; // exception
        }
    }
}
