using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssembly.Pages
{
    public class DataBindingBase : ComponentBase
    {
        [Parameter]
        public RenderFragment HeadingHtml { get; set; }

        [Parameter]
        public string FirstName { get; set; } = "Teppo";
        [Parameter]
        public string LastName { get; set; } = "Demo";
    }
}
