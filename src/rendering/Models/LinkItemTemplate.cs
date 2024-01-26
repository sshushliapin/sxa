using Sitecore.AspNet.RenderingEngine.Binding.Attributes;
using Sitecore.LayoutService.Client.Response.Model.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sxa.Models
{
    public class LinkItemTemplate
    {
        [SitecoreComponentField(Name = "textField")]
        public TextField TextField { get; set; } = default!;
    }
}
