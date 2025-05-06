using Microsoft.AspNetCore.Http;

namespace vulnerable_asp_net_core.Controllers
{
    public static class RequestUtils
    {
        public static string GetIfDefined(HttpRequest req, string val)
        {
            var value = req.Query[val].ToString().Trim();

            // Basic sanitization: remove potentially dangerous characters
            // Only allow alphanumeric, dash, underscore, and a few safe symbols
            value = Regex.Replace(value, @"[^\w\-@\.]", string.Empty);

            return value;
        }
    }
}
