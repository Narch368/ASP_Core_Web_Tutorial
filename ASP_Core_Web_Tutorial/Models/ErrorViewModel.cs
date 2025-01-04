namespace ASP_Core_Web_Tutorial.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }// string abc = "biplib" MVP

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
