using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Portfolio.Shared
{
	[XmlRoot(ElementName = "rss")]
	public class Rss
    {
		[XmlElement(ElementName = "channel")]
		public Channel Channel { get; set; }

		[XmlAttribute(AttributeName = "version")]
		public double Version { get; set; }

		[XmlAttribute(AttributeName = "dc")]
		public string Dc { get; set; }

		[XmlText]
		public string Text { get; set; }
	}
}
