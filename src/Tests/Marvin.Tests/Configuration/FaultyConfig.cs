// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using System.Globalization;

namespace Marvin.Tests.Configuration
{
    public class FaultyConfig
    {
        public static string Content()
        {
            var content =
@"{{
  ""DummyString"": ""{0}"",
  ""Child"": {{
    ""DummyDouble"": {1}
  }},
  ""ConfigState"": ""Generated""
}}";
            return string.Format(content, ModifiedValues.Text, ModifiedValues.Decimal.ToString(CultureInfo.InvariantCulture));
        }
    }
}
