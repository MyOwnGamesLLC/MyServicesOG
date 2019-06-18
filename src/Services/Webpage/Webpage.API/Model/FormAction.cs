using JsonApiDotNetCore.Models;


namespace Webpage.API.Model
{
    public class FormAction : Identifiable<int>
    {

        // TODO: make it dynamically
        public enum EFormAction
        {
            SendEmail
        }

        [HasOne("form")]
        public virtual Form Form { get; set; }
        public int? FormId { get; set; }

        [Attr]
        public string Label { get; set; }

        [Attr]
        public string Code { get; set; }

        [Attr]
        public EFormAction ActionType { get; set; }

        //[Attr]
        //public string ExtendedData { get; set; }

        [Attr]
        public int Position { get; set; }

    }
}