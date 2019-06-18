using JsonApiDotNetCore.Models;

namespace Webpage.API.Model
{
    public class PageRedirectRule : Identifiable
    {
        [Attr]
        public string Name { get; set; }

        //[Attr]
        //public string Conditions { get; set; }

        [Attr]
        public string ToUrl { get; set; }

        //[Attr]
        //public string Value { get; set; }


        // Comentado porque quero ver como faz ActivateModel
        //[Attr] 
        //public string IsActive { get; set; }


    }
}


