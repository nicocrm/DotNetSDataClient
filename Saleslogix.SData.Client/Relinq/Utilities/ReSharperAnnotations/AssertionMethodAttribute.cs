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

namespace JetBrains.Annotations
{
  /// <summary>
  /// Indicates that the marked method is assertion method, i.e. it halts control flow if one of the conditions is satisfied. 
  /// To set the condition, mark one of the parameters with <see cref="AssertionConditionAttribute"/> attribute
  /// </summary>
  /// <seealso cref="AssertionConditionAttribute"/>
  [AttributeUsage (AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
  internal sealed class AssertionMethodAttribute : Attribute
  {
  }
}