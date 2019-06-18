using JsonApiDotNetCore.Models;

namespace Webpage.API.Model
{
    public class Category : Identifiable<int>
    {
        [Attr]
        public string name { get; set; }

        [Attr]
        public string Code { get; set; }

        [Attr]
        public string Description { get; set; }

        [HasOne("parent")]
        public virtual Category Parent { get; set; }
        public int? ParentId { get; set; }






    }
}
