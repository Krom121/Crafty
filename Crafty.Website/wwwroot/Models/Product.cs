﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Crafty.Website.wwwroot.Models
{
    public class Product
    {
        public string Id { get; set; }

        public string Maker { get; set; }

        // mapping the name image to the json img.
        [JsonPropertyName("img")]

        public string Image { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);
        

    }
}
