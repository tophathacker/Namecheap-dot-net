﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace NameCheap
{
    public class DnsHostsRequest
    {
        public string SLD { get; set; }
        public string TLD { get; set; }
        public HostEntry[] HostEntries { get; set; }
    }

    public class HostEntry
    {
        [XmlAttribute("HostId")]
        public int Id { get; set; }
        [XmlAttribute("Name")]
        public string HostName { get; set; }
        [XmlAttribute("Type")]
        public RecordType RecordType { get; set; }
        [XmlAttribute("Address")]
        public string Address { get; set; }
        [XmlAttribute("MXPref")]
        public string MxPref { get; set; }
        [XmlAttribute("TTL")]
        public string Ttl { get; set; }
    }
}
