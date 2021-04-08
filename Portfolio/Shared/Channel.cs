using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Portfolio.Shared
{
	[XmlRoot(ElementName = "channel")]
	public class Channel
    {
		[XmlElement(ElementName = "title")]
		public string Title { get; set; }

		[XmlElement(ElementName = "description")]
		public object Description { get; set; }

		[XmlElement(ElementName = "link")]
		public string Link { get; set; }

		[XmlElement(ElementName = "item")]
		public List<Item> Item { get; set; }
	}
}
