using Microsoft.OpenApi.Models;

namespace TweetBook
{
    internal class Info : OpenApiInfo
    {
        public string Title { get; set; }
        public string Version { get; set; }
    }
}