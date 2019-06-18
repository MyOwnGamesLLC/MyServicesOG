using JsonApiDotNetCore.Models;

namespace Webpage.API.Model
{
    public class FormField : Identifiable<int>
    {
        public enum EFormLabelPosition
        {
            Before,
            After
        }

        [HasOne("form")]
        public virtual Form Form { get; set; }
        public int? FormId { get; set; }

        [Attr]
        public string Label { get; set; }

        [Attr]
        public string Code { get; set; }

        [Attr]
        public string FieldType { get; set; }

        [Attr]
        public string InputType { get; set; }

        [Attr]
        public bool IsRequired { get; set; }

        [Attr]
        public string DefaultValue { get; set; }

        [Attr]
        public EFormLabelPosition LabelPosition { get; set; }

        [Attr]
        public string ElementClass { get; set; }

        [Attr]
        public string WrapperClass { get; set; }


        [Attr]
        public string Placeholder { get; set; }

        //[Attr]
        //public string ExtendedData { get; set; }

        [Attr]
        public int Position { get; set; }

    }
}
