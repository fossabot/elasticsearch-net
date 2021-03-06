﻿using System.Runtime.Serialization;
using Elasticsearch.Net;


namespace Nest
{
	[StringEnum]
	public enum FunctionScoreMode
	{
		[EnumMember(Value = "multiply")]
		Multiply,

		[EnumMember(Value = "sum")]
		Sum,

		[EnumMember(Value = "avg")]
		Average,

		[EnumMember(Value = "first")]
		First,

		[EnumMember(Value = "max")]
		Max,

		[EnumMember(Value = "min")]
		Min
	}
}
