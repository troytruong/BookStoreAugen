﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UnitOfWorks.HttpContext.BookStore.Responses
{
    public class VolumeInfo
    {
        public string Title { get; set; }

        public string Subtitle { get; set; }

        public string Description { get; set; }

        public ICollection<string> Authors { get; set; }

        public string Publisher { get; set; }

        public string PublishedDate { get; set; }

        public ICollection<IndustryIdentifier> IndustryIdentifiers { get; set; }

        public ReadingModes ReadingModes { get; set; }

        public int PageCount { get; set; }

        public string PrintType { get; set; }

        public ICollection<string> Categories { get; set; }

        public string MaturityRating { get; set; }

        public bool AllowAnonLogging { get; set; }

        public string ContentVersion { get; set; }

        public ImageLinks ImageLinks { get; set; }

        public string Language { get; set; }

        public string PreviewLink { get; set; }

        public string InfoLink { get; set; }

        public string CanonicalVolumeLink { get; set; }

    }
}
