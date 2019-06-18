using JsonApiDotNetCore.Models;

namespace Webpage.API.Model
{
    public class Form : Identifiable<int>
    {
        public enum EFormLabelPosition
        {
            Before,
            After
        }

        [Attr]
        public string Title { get; set; }

        [Attr]
        public string Code { get; set; }

        [Attr]
        public bool ShowTitle { get; set; }

        [Attr]
        public bool ClearOnComplete { get; set; }

        [Attr]
        public bool HideOnComplete { get; set; }

        [Attr]
        public string SuccessMessage { get; set; }

        [Attr]
        public string ErrorMessage { get; set; }

        [Attr]
        public string ErrorRequired { get; set; }

        [Attr]
        public string ErrorEmail { get; set; }

        [Attr]
        public string ErrorDate { get; set; }

        [Attr]
        public string ErrorMatch { get; set; }

        [Attr]
        public string ErrorMinLength { get; set; }

        [Attr]
        public string ErrorMaxLength { get; set; }

        [Attr]
        public string ErrorInvalid { get; set; }

        [Attr]
        public string ErrorValidation { get; set; }

        [Attr]
        public string ErrorHoneypot { get; set; }

    }
}