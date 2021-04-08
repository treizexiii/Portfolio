using System;
using System.Xml.Serialization;

namespace Portfolio.Shared
{
	[XmlRoot(ElementName = "item")]
	public class Item
    {
		[XmlElement(ElementName = "title")]
		public string Title { get; set; }

		[XmlElement(ElementName = "description")]
		public string Description { get; set; }

		[XmlElement(ElementName = "link")]
		public string Link { get; set; }

		[XmlElement(ElementName = "pubDate")]
		public string PubDate { get; set; }

		[XmlElement(ElementName = "guid")]
		public string Guid { get; set; }
	}
}
