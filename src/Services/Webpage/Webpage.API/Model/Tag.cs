using JsonApiDotNetCore.Models;

namespace Webpage.API.Model
{
    public class Tag : Identifiable<int>
    {
        [Attr]
        public string Name { get; set; }

        [Attr]
        public string Code { get; set; }

        [Attr]
        public int Count { get; set; }

        [Attr]
        public string Description { get; set; }


    }
}
