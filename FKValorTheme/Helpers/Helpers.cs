using Newtonsoft.Json.Linq;
using OrchardCore.ContentManagement;

namespace FKValorTheme.Helpers
{
    public static class Helpers
    {
        public static string GetImagePath(object imageContent, string width = "500", string height = "300")
        {
            if (!(imageContent is JObject jObject)) return null;
            var contentItem = jObject.ToObject<ContentItem>();
            return "/media/" + contentItem.Content.Paths[0] + "?width=" + width + "&height=" + height;
        }
    }
}