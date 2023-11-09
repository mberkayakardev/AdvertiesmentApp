﻿using AkarSoftware.Core.Entities.Abstract;

namespace AkarSoftware.Entities.Concrete
{
    public class ProviderServices : BaseEntity
    {
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
