// Copyright (c) 2023, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

namespace Moryx.Runtime.Endpoints.Common.Endpoint.Response
{
    /// <summary>
    /// Response model for the server time
    /// </summary>
    public class ServerTimeResponse
    {
        /// <summary>
        /// Server time as string
        /// </summary>
        public string ServerTime { get; set; }
    }
}
