﻿//
// IDynamicClassInfo.cs
//
// Author: Kay Stuckenschmidt <dev-guru@responsive-it.biz>
//
// Copyright (c) 2010 responsive IT
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

using System;
using System.Reflection;

namespace InMemoryLoaderBase
{
    /// <summary>
    /// The initialized object which is stored in the ClassRegistry
    /// </summary>
    public interface IDynamicClassInfo
    {
        /// <summary>
        /// The full type
        /// </summary>
        /// <value>The type of the class.</value>
        Type ClassType { get; set; }

        /// <summary>
        /// The initialized class object
        /// </summary>
        /// <value>The class object.</value>
        object ClassObject { get; set; }

        /// <summary>
        /// The public, usable methods
        /// </summary>
        /// <returns>The methods.</returns>
        MethodInfo [] GetMethods ();
    }

}