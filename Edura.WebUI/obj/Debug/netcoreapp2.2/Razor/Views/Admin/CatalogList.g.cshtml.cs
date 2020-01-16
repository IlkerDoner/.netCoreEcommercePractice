#pragma checksum "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0412e4074438a4e3cc9118f800860047b00cdad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CatalogList), @"mvc.1.0.view", @"/Views/Admin/CatalogList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/CatalogList.cshtml", typeof(AspNetCore.Views_Admin_CatalogList))]
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
#line 1 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\_ViewImports.cshtml"
using Edura.WebUI;

#line default
#line hidden
#line 2 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\_ViewImports.cshtml"
using Edura.WebUI.Models;

#line default
#line hidden
#line 3 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\_ViewImports.cshtml"
using Edura.WebUI.Entity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0412e4074438a4e3cc9118f800860047b00cdad", @"/Views/Admin/CatalogList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e789d86202787a6a7b3bcc76fb6660a1d9c6860", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CatalogList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CatalogListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
  
    ViewData["Title"] = "CatalogList";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(124, 378, true);
            WriteLiteral(@"
<h2>Catalog</h2>

<hr />

<div class=""card"">
    <div class=""card-header"">
        Categories
    </div>

    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th>#</th>
                <th>CategoryName</th>
                <th style=""width:135px""></th>
            </tr>
        </thead>
        <tbody id=""categories"">
");
            EndContext();
#line 25 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
             foreach (var item in Model.categories)
            {

#line default
#line hidden
            BeginContext(570, 46, true);
            WriteLiteral("                <tr>\r\n                    <th>");
            EndContext();
            BeginContext(617, 15, false);
#line 28 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
                   Write(item.CategoryId);

#line default
#line hidden
            EndContext();
            BeginContext(632, 31, true);
            WriteLiteral("</th>\r\n                    <td>");
            EndContext();
            BeginContext(664, 17, false);
#line 29 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
                   Write(item.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(681, 57, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(738, 123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0412e4074438a4e3cc9118f800860047b00cdad7181", async() => {
                BeginContext(853, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 31 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
                                                                              WriteLiteral(item.CategoryId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(861, 131, true);
            WriteLiteral("\r\n                        <button class=\"btn btn-danger btn-sm\">Delete</button>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 35 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
            }

#line default
#line hidden
            BeginContext(1007, 176, true);
            WriteLiteral("\r\n\r\n        </tbody>\r\n    </table>\r\n    <div class=\"card-footer\">\r\n        <button class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#addCategoryModal\">Create</button>\r\n");
            EndContext();
            BeginContext(1247, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1256, 59, false);
#line 43 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
   Write(await Html.PartialAsync("_addCategoryForm", new Category()));

#line default
#line hidden
            EndContext();
            BeginContext(1315, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1344, 1530, true);
                WriteLiteral(@"
            <script>
                $(""#addCategory"").submit(function (event) {
                    event.preventDefault();
                    var form = $(this);
                    var token = $('input[name=""__RequestVerificationToken""]', form).val();

                    var data = { categoryName: $(""#CategoryName"").val() };

                    var dataWithToken = $.extend(data, { '__RequestVerificationToken': token }); // ikialt cizgi dikkat et

                    $.ajax({
                        url: form.attr(""Action""),
                        type: ""POST"",
                        data: dataWithToken,
                        beforeSend: function () {
                            $(""#ajax-loader"").show();
                        },
                        complete: function myfunction() {
                            $(""#ajax-loader"").hide();
                        },
                        success: function (data) {
                            console.log(data);
             ");
                WriteLiteral(@"               var html = '<tr><th>' + data.categoryId + '</th><td>' + data.categoryName + '</td><td><button class=""btn btn-primary btn-sm"">Edit</button><button class=""btn btn-danger btn-sm"">Delete</button></td></tr>'
                            $(""#categories"").append(html);
                            $(""#addCategoryModal"").modal('hide');
                        }, error: function () {

                        }

                    })


                });
            </script>
        ");
                EndContext();
            }
            );
            BeginContext(2877, 531, true);
            WriteLiteral(@"
    </div>
</div>

<hr />

<div class=""card"">
    <div class=""card-header"">
        Products
    </div>

    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th>#</th>
                <th>Image</th>
                <th>ProductName</th>
                <th>Date</th>
                <th>IsApproved</th>
                <th>IsHome</th>
                <th>IsFeatured</th>
                <th style=""width:135px""></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 106 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
             foreach (var item in Model.products)
            {

#line default
#line hidden
            BeginContext(3474, 48, true);
            WriteLiteral("                <tr>\r\n\r\n                    <th>");
            EndContext();
            BeginContext(3523, 14, false);
#line 110 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
                   Write(item.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(3537, 57, true);
            WriteLiteral("</th>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3594, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d0412e4074438a4e3cc9118f800860047b00cdad14054", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3604, "~/images/products/tn/", 3604, 21, true);
#line 112 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
AddHtmlAttributeValue("", 3625, item.Image, 3625, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3651, 53, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
            EndContext();
            BeginContext(3705, 16, false);
#line 114 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
                   Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(3721, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(3753, 14, false);
#line 115 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
                   Write(item.DateAdded);

#line default
#line hidden
            EndContext();
            BeginContext(3767, 33, true);
            WriteLiteral("</td>\r\n                    <td>\r\n");
            EndContext();
#line 117 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
                         if (@item.IsApproved)
                        {

#line default
#line hidden
            BeginContext(3875, 71, true);
            WriteLiteral("                            <span data-feather=\"check-square\"></span>\r\n");
            EndContext();
#line 120 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(4030, 67, true);
            WriteLiteral("                            <span data-feather=\"x-square\"></span>\r\n");
            EndContext();
#line 124 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
                        }

#line default
#line hidden
            BeginContext(4124, 53, true);
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
            EndContext();
#line 127 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
                         if (@item.IsHome)
                        {

#line default
#line hidden
            BeginContext(4248, 71, true);
            WriteLiteral("                            <span data-feather=\"check-square\"></span>\r\n");
            EndContext();
#line 130 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(4403, 67, true);
            WriteLiteral("                            <span data-feather=\"x-square\"></span>\r\n");
            EndContext();
#line 134 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
                        }

#line default
#line hidden
            BeginContext(4497, 53, true);
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
            EndContext();
#line 137 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
                         if (@item.IsFeatured)
                        {

#line default
#line hidden
            BeginContext(4625, 71, true);
            WriteLiteral("                            <span data-feather=\"check-square\"></span>\r\n");
            EndContext();
#line 140 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(4780, 67, true);
            WriteLiteral("                            <span data-feather=\"x-square\"></span>\r\n");
            EndContext();
#line 144 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
                        }

#line default
#line hidden
            BeginContext(4874, 260, true);
            WriteLiteral(@"                    </td>
                    <td>
                        <button class=""btn btn-primary btn-sm"">Edit</button>
                        <button class=""btn btn-danger btn-sm"">Delete</button>
                    </td>
                </tr>
");
            EndContext();
#line 151 "C:\Users\ILKER\Source\repos\Edura\Edura.WebUI\Views\Admin\CatalogList.cshtml"
            }

#line default
#line hidden
            BeginContext(5149, 75, true);
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n</div>\r\n\r\n<div class=\"card-footer\">\r\n    ");
            EndContext();
            BeginContext(5224, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0412e4074438a4e3cc9118f800860047b00cdad20224", async() => {
                BeginContext(5299, 6, true);
                WriteLiteral("Create");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5309, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CatalogListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591