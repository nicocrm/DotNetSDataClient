﻿// Copyright (c) 1997-2013, SalesLogix NA, LLC. All rights reserved.

using System.Net;
using Saleslogix.SData.Client.Framework;

#if !NET_2_0 && !NET_3_5
using System.Threading.Tasks;
#endif

namespace Saleslogix.SData.Client
{
    public interface ISDataClient
    {
        string Uri { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        string UserAgent { get; set; }
        int? Timeout { get; set; }
        int? TimeoutRetryAttempts { get; set; }
#if !PCL && !SILVERLIGHT
        IWebProxy Proxy { get; set; }
#endif
        ICredentials Credentials { get; set; }
        INamingScheme NamingScheme { get; set; }
        MediaType? Format { get; set; }
        string Language { get; set; }

#if !PCL && !NETFX_CORE && !SILVERLIGHT
        ISDataResults Execute(ISDataParameters parms);
        ISDataResults<T> Execute<T>(ISDataParameters parms);
#endif

#if !NET_2_0 && !NET_3_5
        Task<ISDataResults> ExecuteAsync(ISDataParameters parms);
        Task<ISDataResults<T>> ExecuteAsync<T>(ISDataParameters parms);
#endif
    }
}