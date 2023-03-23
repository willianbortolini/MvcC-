using System;

namespace salesWebMvc4.Models.ViewsModels
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public string Messege { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}