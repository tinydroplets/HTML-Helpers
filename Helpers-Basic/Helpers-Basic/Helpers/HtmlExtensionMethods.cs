using System.Web;
using System.Web.Mvc;

namespace Helpers_Basic.Helpers
{
    public static  class HtmlExtensionMethods
    {
        public static IHtmlString LabelWithMark(this HtmlHelper helper, string content)
        {
            var htmlString = $"<label><mark>{content}<mark></label>";
            return new HtmlString(htmlString);
        }
    }
}