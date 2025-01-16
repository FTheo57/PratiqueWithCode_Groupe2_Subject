using EvaluationSampleCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace EvaluationSampleCode.Tests
{
    [TestClass]
    public class HtmlFormatHelperTests
    {
        [TestMethod]
        public void GetStrongFormat_ValidContent_ReturnsStrongTag()
        {

            var helper = new HtmlFormatHelper();
            var content = "Hello World";


            var result = helper.GetStrongFormat(content);


            Assert.AreEqual("<strong>Hello World</strong>", result);
        }

        [TestMethod]
        public void GetItalicFormat_ValidContent_ReturnsItalicTag()
        {

            var helper = new HtmlFormatHelper();
            var content = "Test";

            var result = helper.GetItalicFormat(content);


            Assert.AreEqual("<i>Test</i>", result);
        }

        [TestMethod]
        public void GetFormattedListElements_ValidList_ReturnsListHtml()
        {

            var helper = new HtmlFormatHelper();
            var contents = new List<string> { "Item1", "Item2", "Item3" };


            var result = helper.GetFormattedListElements(contents);


            var expectedHtml = "<ul><li>Item1</li><li>Item2</li><li>Item3</li></ul>";
            Assert.AreEqual(expectedHtml, result);
        }
    }
}
