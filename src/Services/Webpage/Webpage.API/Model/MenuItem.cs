using JsonApiDotNetCore.Models;

namespace Webpage.API.Model
{
    public class MenuItem : Identifiable<int>
    {

        public enum EMenuItemTarget
        {
            Blank,
            Self,
            Parent,
            Top
        }


        [HasOne("menu")]
        public virtual Menu Menu { get; set; }
        public int? MenuId { get; set; }

        [HasOne("parent")]
        public virtual MenuItem Parent { get; set; }
        public int? ParentId { get; set; }


        [Attr]
        public string Name { get; set; }

        [Attr]
        public string Url { get; set; }

        [Attr]
        public string Fragment { get; set; }

        [Attr]
        public string Icon { get; set; }

        [Attr]
        public string Alt { get; set; }

        [Attr]
        public string CssClass { get; set; }

        [Attr]
        public EMenuItemTarget Target { get; set; }

        [Attr]
        public int Position { get; set; }


    }
}
