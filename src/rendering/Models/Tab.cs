using Sitecore.LayoutService.Client.Response.Model.Fields;

namespace sxa.Models
{
    public class Tab
    {
        public TextField Title { get; set; } = default!;

        public RichTextField Content { get; set; } = default!;
    }
}
