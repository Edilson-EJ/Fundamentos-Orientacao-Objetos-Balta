

namespace Balta.ContentContext

{
    public abstract class Content
    {

        public Content()
        {
            Id = Guid.NewGuid();
        }

       public int Guid { get; set; }

       public string Title { get; set; }

       public  string Url { get; set; }
    }
}

