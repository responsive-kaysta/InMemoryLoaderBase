﻿//
// Test.cs
//
// Author: responsive kaysta
//
// Copyright (c) 2018 responsive kaysta
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

using System.Configuration;
using NUnit.Framework;

namespace InMemoryLoaderBase.UnitTests
{
    /// <summary>
    /// InMemoryLoaderBase test cases
    /// </summary>
    [TestFixture()]
    public class Test
    {
        private static string ApplicationKey { get; } = ConfigurationManager.AppSettings["ApplicationKey"];

        /// <summary>
        /// AbstractComponent test
        /// </summary>
        [Test()]
        public void AbstractComponentTest()
        {
            var component = new AbstractComponentHelper();
            const string key = AbstractComponent.Key;

            var init1 = component.Init(key);
            var init2 = component.Init(ApplicationKey);

            Assert.IsTrue(init1);
            Assert.IsTrue(init2);
            Assert.AreEqual(ApplicationKey, key);
        }




    }

}
