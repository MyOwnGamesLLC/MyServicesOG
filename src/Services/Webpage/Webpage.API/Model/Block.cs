using JsonApiDotNetCore.Models;

namespace Webpage.API.Model
{
    public class Block : Identifiable<int>
    {
        public enum EBlockClass
        {
            Simple,
            WidgetHolder,
            Layout,
            Header,
            Footer
        }


        [Attr]
        public EBlockClass BlockClass { get; set; }

        public string Title { get; set; }

        public string Code { get; set; }

        public bool IsSystem { get; set; }

        public string Content { get; set; }

        // public Json Settings { get; set; }



    }
}
