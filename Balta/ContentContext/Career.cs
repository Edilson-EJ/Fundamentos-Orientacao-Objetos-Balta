
namespace Balta.ContentContext
{


    public class Career : Content
    {

        public Career()
        {
            Items = new List<CareerItem>();
        }

        public IList<CareerItem> Items { get; set; }
    }

    public class CareerItem
    {
        public CareerItem()
        {
            Courses = new List<Courses>();
        }

        public int Order { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public IList<Courses> Courses { get; set; }
    }
}

