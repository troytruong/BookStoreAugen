using System;
using System.Collections.Generic;
using System.Text;

namespace UnitOfWorks.HttpContext.BookStore.Responses
{
    public class AccessInfo
    {
        public string Country { get; set; }

        public string Viewability { get; set; }

        public bool Embeddable { get; set; }

        public bool PublicDomain { get; set; }

        public string TextToSpeechPermission { get; set; }

        public BookType Epub { get; set; }

        public BookType Pdf { get; set; }

        public string WebReaderLink { get; set; }

        public string AccessViewStatus { get; set; }

        public bool QuoteSharingAllowed { get; set; }
    }
}
