﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSerialization.Models
{

    public class Book
    {
        public string Id { get; set; }

        public string Isbn { get; set; }

        public string Author { get; set; }

        public string Title { get; set; }

        public string Publisher { get; set; }

        public DateTime PublishDate { get; set; }

        public string Description { get; set; }

        public DateTime RegistrationDate { get; set; }

    }
}
