﻿//
// InMemoryLoaderBaseNunit.cs
//
// Author: Kay Stuckenschmidt <mailto.kaysta@gmail.com>
//
// Copyright (c) 2017 responsive-kaysta
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

using NUnit.Framework;
using System.Configuration;

namespace InMemoryLoaderBaseNunit
{
    /// <summary>
    /// In memory loader base test class.
    /// </summary>
    [TestFixture()]
    public class InMemoryLoaderBaseTests
    {
        /// <summary>
        /// Gets the console culture.
        /// </summary>
        /// <value>The console culture.</value>
        static readonly string ConsoleCulture = ConfigurationManager.AppSettings["ConsoleCulture"];

        /// <summary>
        /// Gets the application key.
        /// </summary>
        /// <value>The application key.</value>
        static readonly string ApplicationKey = ConfigurationManager.AppSettings["ApplicationKey"];

        /// <summary>
        /// AbstractPowerUpComponent Test Case
        /// </summary>
        [Test()]
        public void InMmoryLoaderBaseTest()
        {
            var testHelper = new TestHelper();
            var isInit = testHelper.Init(ApplicationKey);
           
            Assert.IsTrue(isInit);

            var equals = string.Equals(ApplicationKey, testHelper.AppKey);
            Assert.IsTrue(equals);

            Assert.IsNotEmpty(ConsoleCulture);

            Assert.IsTrue(testHelper.IterateDateInterval());
            Assert.IsTrue(testHelper.IterateDateTimeAmPmType());
            Assert.IsTrue(testHelper.IterateFileCompareMethod());
            Assert.IsTrue(testHelper.IterateHashAlgorithmKind());
            Assert.IsTrue(testHelper.IterateStringDirection());
        }

    }

}