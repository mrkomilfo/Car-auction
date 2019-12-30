#pragma checksum "D:\ASP\Auction\Auction\Views\Lots\LotsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b172eced24aa88379fcfba15012b46f045d62d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lots_LotsList), @"mvc.1.0.view", @"/Views/Lots/LotsList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Lots/LotsList.cshtml", typeof(AspNetCore.Views_Lots_LotsList))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\ASP\Auction\Auction\Views\_ViewImports.cshtml"
using Auction.ViewModels;

#line default
#line hidden
#line 2 "D:\ASP\Auction\Auction\Views\_ViewImports.cshtml"
using Auction.Data.Models;

#line default
#line hidden
#line 3 "D:\ASP\Auction\Auction\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\ASP\Auction\Auction\Views\_ViewImports.cshtml"
using Auction.TagHelpers;

#line default
#line hidden
#line 5 "D:\ASP\Auction\Auction\Views\_ViewImports.cshtml"
using static Auction.Data.Dict;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b172eced24aa88379fcfba15012b46f045d62d8", @"/Views/Lots/LotsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48e1f3edcad600800ae6ddf36380b52643555de7", @"/Views/_ViewImports.cshtml")]
    public class Views_Lots_LotsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 26, true);
            WriteLiteral("<div id=\"scrolList\">\r\n    ");
            EndContext();
            BeginContext(27, 43, false);
#line 2 "D:\ASP\Auction\Auction\Views\Lots\LotsList.cshtml"
Write(await Html.PartialAsync("_LotsListPartial"));

#line default
#line hidden
            EndContext();
            BeginContext(70, 898, true);
            WriteLiteral(@"
</div>

<script>
$(function () {
    var page = 0;
    var _inCallback = false;
    function loadItems() {
        if (page > -1 && !_inCallback) {
            _inCallback = true;
            page++;

            $.ajax({
                type: 'GET',
                url: '/Lots/Ended/' + page,
                success: function (data) {
                    if (data != '') {
                        $(""#scrolList"").append(data);
                    }
                    else {
                        page = -1;
                    }
                    _inCallback = false;
                }
            });
        }
    }
    // обработка события скроллинга
    $(window).scroll(function () {
        if ($(window).scrollTop() + $(window).height() > $(document).height() - $(document).height()/4) {
            loadItems();
        }
    });
})
</script>

");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
