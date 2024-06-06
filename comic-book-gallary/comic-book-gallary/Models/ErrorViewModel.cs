namespace comic_book_gallary. Models
    {
    public class ErrorViewModel
        {
        public string? RequestId
            {
            get; set;
            }

        public bool ShowRequestId => !string. IsNullOrEmpty(RequestId);
        }
    }
