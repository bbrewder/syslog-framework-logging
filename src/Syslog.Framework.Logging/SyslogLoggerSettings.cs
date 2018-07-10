using BizArk.Core.Extensions.StringExt;
using BizArk.Core.Util;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Syslog.Framework.Logging
{
	public class SyslogLoggerSettings
	{

		#region Fields and Methods

		/// <summary>
		/// Gets or sets the host for the Syslog server.
		/// </summary>
		public string ServerHost { get; set; }

		/// <summary>
		/// Gets or sets the port for the Syslog server.
		/// </summary>
		public int ServerPort { get; set; }

		/// <summary>
		/// Gets or sets the facility type.
		/// </summary>
		public FacilityType FacilityType { get; set; } = FacilityType.Local0;

		/// <summary>
		/// Gets or sets the header type. Set this instead of HeaderFormat.
		/// </summary>
		public SyslogHeaderType HeaderType { get; set; } = SyslogHeaderType.Rfc3164;

		/// <summary>
		/// Structured data that is sent with every request. Only for RFC 5424.
		/// </summary>
		public List<SyslogStructuredData> StructuredData { get; private set; } = new List<SyslogStructuredData>();

		/// <summary>
		/// Gets or sets whether to log messages using UTC or local time. Defaults to true (UTC).
		/// </summary>
		public bool UseUtc { get; set; } = true;

		#endregion

	}
	
	/// <summary>
	/// Allows sending of structured data in RFC 5424.
	/// </summary>
	public class SyslogStructuredData
	{

		/// <summary>
		/// Creates an instance of SyslogStructuredData.
		/// </summary>
		/// <param name="id"></param>
		public SyslogStructuredData(string id)
		{
			Id = id;
		}

		/// <summary>
		/// Gets the ID for the structured data.
		/// </summary>
		public string Id { get; private set; }

		/// <summary>
		/// Gets the list of structured data elements.
		/// </summary>
		public List<SylogStructuredDataElement> Elements { get; private set; } = new List<SylogStructuredDataElement>();

	}

	/// <summary>
	/// A named value for structured data.
	/// </summary>
	public class SylogStructuredDataElement
	{

		/// <summary>
		/// Creates an instance of SylogStructuredDataElement.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		public SylogStructuredDataElement(string name, string value)
		{
			Name = name;
			Value = value;
		}

		/// <summary>
		/// Gets the name of the element.
		/// </summary>
		public string Name { get; private set; }

		/// <summary>
		/// Gets the value of the element.
		/// </summary>
		public string Value { get; private set; }

	}
}
