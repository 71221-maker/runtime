// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#nullable enable

namespace System.Data.Common
{
    public abstract class DbDataSourceEnumerator
    {
        protected DbDataSourceEnumerator() { }
        public abstract DataTable GetDataSources();
    }
}
