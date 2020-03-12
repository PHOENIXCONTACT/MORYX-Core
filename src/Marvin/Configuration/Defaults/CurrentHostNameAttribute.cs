// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using System;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;

namespace Marvin.Configuration
{
    /// <summary>
    /// Default value attribute which provides the current HostName of this computer
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class CurrentHostNameAttribute : DefaultValueAttribute
    {
        /// <summary>
        /// Creates a new instance of <see cref="CurrentHostNameAttribute"/>
        /// </summary>
        public CurrentHostNameAttribute() : base("localhost")
        {
            try
            {
                SetValue(Dns.GetHostName());
            }
            catch (SocketException)
            {
                // ignored -> default is "localhost"
            }
        }
    }
}
