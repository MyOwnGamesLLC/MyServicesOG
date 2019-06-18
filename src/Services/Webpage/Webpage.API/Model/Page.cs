using JsonApiDotNetCore.Models;
using System.Collections.Generic;

namespace Webpage.API.Model
{
    public class Page : Identifiable
    {
        public enum EPageClass
        {
            Static,
            Post,
            Product,
            // TODO: Event,
            // TODO: Gallery
        }

        public enum EPostType
        {
            Article,
            Video,
            Audio,
            Image
        }

        [Attr]
        public EPageClass PageClass { get; set; }

        [Attr]
        public string Title { get; set; }

        [Attr]
        public string Content { get; set; }

        [HasOne("layout")]
        public virtual Block Layout { get; set; }
        public int? LayoutId { get; set; }

        [HasOne("header")]
        public virtual Block Header { get; set; }
        public int? HeaderId { get; set; }

        [HasOne("footer")]
        public virtual Block Footer { get; set; }
        public int? FooterId { get; set; }

        [HasMany("categories")]
        public virtual List<Category> Categories { get; set; }

        [HasMany("tags")]
        public virtual List<Tag> Tags { get; set; }

        // POST Only:

        public EPostType? PostType { get; set; }



    }
}


