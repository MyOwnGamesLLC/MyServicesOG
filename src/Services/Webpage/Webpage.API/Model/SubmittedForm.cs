using JsonApiDotNetCore.Models;


namespace Webpage.API.Model
{
    public class SubmittedForm : Identifiable<int>
    {

        [HasOne("form")]
        public virtual Form Form { get; set; }
        public int? FormId { get; set; }

        //[Attr]
        //public string ExtendedData { get; set; }

    }
}