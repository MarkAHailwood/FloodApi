using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FloodInfo.lib.Models
{
        public class FloodModel
        {
            [JsonProperty("@context")]
            public string Context { get; set; }
            public Meta meta { get; set; }
            public List<Item> items { get; set; }
        
            public class Meta
            {
                public string publisher { get; set; }
                public string licence { get; set; }
                public string documentation { get; set; }
                public string version { get; set; }
                public string comment { get; set; }
                public List<string> hasFormat { get; set; }
            }

            public class FloodArea
            {
                [JsonProperty("@id")]
                public string Id { get; set; }
                public string county { get; set; }
                public string notation { get; set; }
                public string polygon { get; set; }
                public string riverOrSea { get; set; }
            }

            public class Item
            {
                [JsonProperty("@id")]
                public string Id { get; set; }
                public string description { get; set; }
                public string eaAreaName { get; set; }
                public string eaRegionName { get; set; }
                public FloodArea floodArea { get; set; }
                public string floodAreaID { get; set; }
                public bool isTidal { get; set; }
                public string message { get; set; }
                public string severity { get; set; }
                public int severityLevel { get; set; }
                public DateTime timeMessageChanged { get; set; }
                public DateTime timeRaised { get; set; }
                public DateTime timeSeverityChanged { get; set; }
            }       
        }
}


    

