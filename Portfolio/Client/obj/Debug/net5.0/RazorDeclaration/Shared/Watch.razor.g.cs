// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Portfolio.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "d:\Projet c#\Portfolio\Portfolio\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\Projet c#\Portfolio\Portfolio\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\Projet c#\Portfolio\Portfolio\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "d:\Projet c#\Portfolio\Portfolio\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "d:\Projet c#\Portfolio\Portfolio\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "d:\Projet c#\Portfolio\Portfolio\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "d:\Projet c#\Portfolio\Portfolio\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "d:\Projet c#\Portfolio\Portfolio\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "d:\Projet c#\Portfolio\Portfolio\Client\_Imports.razor"
using Portfolio.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "d:\Projet c#\Portfolio\Portfolio\Client\_Imports.razor"
using Portfolio.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "d:\Projet c#\Portfolio\Portfolio\Client\_Imports.razor"
using Portfolio.Client.Services.FeedServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "d:\Projet c#\Portfolio\Portfolio\Client\_Imports.razor"
using Portfolio.Client.Services.GithubServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "d:\Projet c#\Portfolio\Portfolio\Client\_Imports.razor"
using Portfolio.Client.Services.MailService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "d:\Projet c#\Portfolio\Portfolio\Client\_Imports.razor"
using Portfolio.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "d:\Projet c#\Portfolio\Portfolio\Client\_Imports.razor"
using BlazorAnimate;

#line default
#line hidden
#nullable disable
    public partial class Watch : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "d:\Projet c#\Portfolio\Portfolio\Client\Shared\Watch.razor"
       
    protected override async Task OnInitializedAsync()
    {
        await FeedService.LoadFeeds();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFeedService FeedService { get; set; }
    }
}
#pragma warning restore 1591
