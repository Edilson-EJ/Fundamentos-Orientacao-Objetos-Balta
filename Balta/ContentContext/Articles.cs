
namespace Balta.ContentContext
{
    public class Articles : Content
    {
        public string Title { get; set; }
        public string Url { get; set; }

        public Articles(string title, string url)
        {
            Title = title;
            Url = url;
        }
    }
}

