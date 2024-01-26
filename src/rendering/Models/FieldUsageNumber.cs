using Sitecore.LayoutService.Client.Response.Model.Fields;

namespace sxa.Models
{
    public class FieldUsageNumber : HeadingAndDescription
    {
        public NumberField Sample { get; set; } = default!;
    }
}
