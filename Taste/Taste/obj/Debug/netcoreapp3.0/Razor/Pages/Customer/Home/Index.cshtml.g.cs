#pragma checksum "C:\Users\furkan\Desktop\odev2\Taste-master\Taste-master\Taste\Pages\Customer\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4245c979ffbeb27e9920987b301be74ca0bf56e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Taste.Pages.Customer.Home.Pages_Customer_Home_Index), @"mvc.1.0.razor-page", @"/Pages/Customer/Home/Index.cshtml")]
namespace Taste.Pages.Customer.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\furkan\Desktop\odev2\Taste-master\Taste-master\Taste\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\furkan\Desktop\odev2\Taste-master\Taste-master\Taste\Pages\_ViewImports.cshtml"
using Taste;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4245c979ffbeb27e9920987b301be74ca0bf56e7", @"/Pages/Customer/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db8d439dec68e5f440316ec24cb27e88e3a04e45", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Customer_Home_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius:2px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\furkan\Desktop\odev2\Taste-master\Taste-master\Taste\Pages\Customer\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 7 "C:\Users\furkan\Desktop\odev2\Taste-master\Taste-master\Taste\Pages\Customer\Home\Index.cshtml"
 foreach(var category in Model.CategoryList)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\furkan\Desktop\odev2\Taste-master\Taste-master\Taste\Pages\Customer\Home\Index.cshtml"
     if(Model.MenuItemList.Where(c=>c.CategoryId==category.Id).Count() >0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row container pb-3 backgroundWhite\">\n            <div class=\"col-12\">\n                <div class=\"row\">\n                    <h2 class=\"text-success pl-1\"><b>");
#nullable restore
#line 14 "C:\Users\furkan\Desktop\odev2\Taste-master\Taste-master\Taste\Pages\Customer\Home\Index.cshtml"
                                                Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h2>\n\n                    <div class=\"col-12\">\n                        <div class=\"row my-3\">\n");
#nullable restore
#line 18 "C:\Users\furkan\Desktop\odev2\Taste-master\Taste-master\Taste\Pages\Customer\Home\Index.cshtml"
                             foreach(var menuItem in Model.MenuItemList.Where(c => c.CategoryId == category.Id))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col-lg-3 col-xl-3 col-md-6 pb-4"">
                                    <div class=""card"" style=""border:2px solid #008cba; border-radius: 5px; "">
                                        <div class=""pl-3 pt-1 text-center"">
                                            <h3 class=""card-title text-primary""><b>");
#nullable restore
#line 23 "C:\Users\furkan\Desktop\odev2\Taste-master\Taste-master\Taste\Pages\Customer\Home\Index.cshtml"
                                                                              Write(menuItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b></h3>
                                        </div>
                                        <div class=""d-flex justify-content-between form-control"" style=""border:0px;"">
                                            <div class=""col-6 badge badge-warning text-center"" style=""font-size:14px;"">
                                                ");
#nullable restore
#line 27 "C:\Users\furkan\Desktop\odev2\Taste-master\Taste-master\Taste\Pages\Customer\Home\Index.cshtml"
                                           Write(menuItem.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            </div>\n                                            <div class=\"col-6 text-right h4\" style=\"color:maroon;\"><b>");
#nullable restore
#line 29 "C:\Users\furkan\Desktop\odev2\Taste-master\Taste-master\Taste\Pages\Customer\Home\Index.cshtml"
                                                                                                 Write(menuItem.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></div>\n                                        </div>\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 1648, "\"", 1669, 1);
#nullable restore
#line 31 "C:\Users\furkan\Desktop\odev2\Taste-master\Taste-master\Taste\Pages\Customer\Home\Index.cshtml"
WriteAttributeValue("", 1654, menuItem.Image, 1654, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top p-2 rounded\" />\n\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4245c979ffbeb27e9920987b301be74ca0bf56e78177", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\furkan\Desktop\odev2\Taste-master\Taste-master\Taste\Pages\Customer\Home\Index.cshtml"
                                                                                                                   WriteLiteral(menuItem.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n                                    </div>\n                                </div>\n");
#nullable restore
#line 37 "C:\Users\furkan\Desktop\odev2\Taste-master\Taste-master\Taste\Pages\Customer\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\n                    </div>\n\n                </div>\n            </div>\n        </div>\n");
#nullable restore
#line 44 "C:\Users\furkan\Desktop\odev2\Taste-master\Taste-master\Taste\Pages\Customer\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\furkan\Desktop\odev2\Taste-master\Taste-master\Taste\Pages\Customer\Home\Index.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Taste.Pages.Customer.Home.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Taste.Pages.Customer.Home.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Taste.Pages.Customer.Home.IndexModel>)PageContext?.ViewData;
        public Taste.Pages.Customer.Home.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591