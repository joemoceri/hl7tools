﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HL7Tools.Validation
{
    public class TriggerEventResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("msgStructId")]
        public string MessageStructureId { get; set; }

        [JsonProperty("eventDesc")]
        public string EventDescription { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("sample")]
        public string Sample { get; set; }

        [JsonProperty("chapters")]
        public IList<string> Chapters { get; set; }

        [JsonProperty("segments")]
        public IList<TriggerEventSegmentResponse> TriggerEventSegments { get; set; }

        public List<SegmentResponse> Segments { get; internal set; }
        
        public List<SegmentGroupResponse> SegmentGroups { get; internal set; }
    }
}
