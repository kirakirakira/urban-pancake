using System.Text;
using System.Text.Json;

namespace UrbanPancake.Library
{
    public class ToolRepository
    {
        private readonly List<Tool> _allTools = new List<Tool>();

        public void Add(Tool tool)
        {
            _allTools.Add(tool);
        }

        public Tool? FindToolWithType(string type)
        {
            Tool? foundTool;
            try
            {
                foundTool = _allTools.Find(tool => tool.Type == type);
                return foundTool;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (_allTools.Count != 0)
            {
                sb.Append("The tools in the repository are: \n");
                foreach (Tool? tool in _allTools)
                {
                    sb.Append(tool.ToString() + "\n");
                }
            }
            else
            {
                sb.Append("There are no tools in the repository.");
            }

            return sb.ToString();
        }

        public ToolRepository()
        {
            var interviews = JsonSerializer.Deserialize<List<Tool>>(File.ReadAllText(@"UrbanPancake/Data/ToolData.json"));

            for (int i = 0; i < interviews?.Count; i++)
            {
                _allTools.Add(interviews[i]);
            }
        }
    }
}
