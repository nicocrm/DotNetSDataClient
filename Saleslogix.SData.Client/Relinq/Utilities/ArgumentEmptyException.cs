// This file is part of the re-linq project (relinq.codeplex.com)
// Copyright (c) rubicon IT GmbH, www.rubicon.eu
// 
// re-linq is free software; you can redistribute it and/or modify it under 
// the terms of the GNU Lesser General Public License as published by the 
// Free Software Foundation; either version 2.1 of the License, 
// or (at your option) any later version.
// 
// re-linq is distributed in the hope that it will be useful, 
// but WITHOUT ANY WARRANTY; without even the implied warranty of 
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the 
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with re-linq; if not, see http://www.gnu.org/licenses.
// 
using System;
using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace Remotion.Linq.Utilities
{
  /// <summary>
  /// This exception is thrown if an argument is empty although it must have a content.
  /// </summary>
  [Serializable]
  internal class ArgumentEmptyException : ArgumentException
  {
    public ArgumentEmptyException ([InvokerParameterName] string paramName)
      : base (FormatMessage (paramName), paramName)
    {
    }

#if !PCL && !NETFX_CORE && !SILVERLIGHT
    public ArgumentEmptyException (SerializationInfo info, StreamingContext context)
        : base (info, context)
    {
    }
#endif

    private static string FormatMessage (string paramName)
    {
      return string.Format ("Parameter '{0}' cannot be empty.", paramName);
    }
  }
}
