using JsonApiDotNetCore.Models;

namespace Webpage.API.Model
{
    public class Menu : Identifiable<int>
    {

        [Attr]
        public string Name { get; set; }

        [Attr]
        public string Code { get; set; }

        [Attr]
        public string WrapperClass { get; set; }

    }
}
