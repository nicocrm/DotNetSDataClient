﻿using NUnit.Framework;
using Saleslogix.SData.Client.Framework;

// ReSharper disable InconsistentNaming

namespace Saleslogix.SData.Client.Test.Framework
{
    [TestFixture]
    public class UriPathParserTests
    {
        /// <summary>
        /// The URI path parser should handle open parentheses characters
        /// in literal string selectors.
        /// </summary>
        [Test]
        public void Literal_String_Selector_With_Open_Paren_Test()
        {
            var segments = UriPathParser.Parse("aaa('bbb(ccc')");
            Assert.That(segments, Is.Not.Null);
            Assert.That(segments.Count, Is.EqualTo(1));

            var segment = segments[0];
            Assert.That(segment.Text, Is.EqualTo("aaa"));
            Assert.That(segment.HasSelector);
            Assert.That(segment.Selector, Is.EqualTo("'bbb(ccc'"));
        }
    }
}