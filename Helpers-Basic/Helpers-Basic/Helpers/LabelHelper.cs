using System.Web;

namespace Helpers_Basic.Helpers
{
    public class LabelHelper
    {
        public static IHtmlString Label(string target, string text)
        {
            return new HtmlString($"<label for='{target}'>{text}</label>");
        }
    }
}