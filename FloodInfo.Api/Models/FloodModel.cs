using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FloodInfo.lib.Models
{
    public class FloodModel
    {
        //public string @context { get; set; }
        //public string[] items { get; set; }
        [JsonProperty("@context")]
        public string context { get; set; }
        public class items
        {
            public string message { get; set; }
        }
        //public List<string> meta { get; set; }
        //public List<List<string>> items { get; set; }
    }
}
