#pragma checksum "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30f29d85afe38f80304c8a6a19d8b92042373c77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Bussines_Views_Courier_Index), @"mvc.1.0.view", @"/Areas/Bussines/Views/Courier/Index.cshtml")]
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
#nullable restore
#line 2 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\_ViewImports.cshtml"
using Final_Project.Areas.Bussines.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\_ViewImports.cshtml"
using Final_Project.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\_ViewImports.cshtml"
using Final_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30f29d85afe38f80304c8a6a19d8b92042373c77", @"/Areas/Bussines/Views/Courier/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adad1f849b9d6b0784f5010f749081b4609c39f7", @"/Areas/Bussines/Views/_ViewImports.cshtml")]
    public class Areas_Bussines_Views_Courier_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/microsoft/signalr/dist/browser/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 9 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\" style=\"width: 18rem; height:auto;\">\r\n                <ul class=\"list-group list-group-flush\">\r\n                    <li class=\"list-group-item\">Client Name ");
#nullable restore
#line 13 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Index.cshtml"
                                                       Write(item.AppUser.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 14 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Index.cshtml"
                     if (item.RestuorantId != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"list-group-item\">Restaurant Adress: ");
#nullable restore
#line 16 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Index.cshtml"
                                                                  Write(item.Restuorant.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 17 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"list-group-item\">Store Adress: ");
#nullable restore
#line 20 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Index.cshtml"
                                                             Write(item.Store.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 21 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <li class=\"list-group-item\">Adress: ");
#nullable restore
#line 23 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Index.cshtml"
                                                   Write(item.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li class=\"list-group-item\">TotalPrice ");
#nullable restore
#line 24 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Index.cshtml"
                                                      Write(item.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                </ul>\r\n                <div class=\"accept-delivery\">\r\n");
#nullable restore
#line 27 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Index.cshtml"
                     if (item.IsCourierFind == false)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div data-id=\"");
#nullable restore
#line 29 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Index.cshtml"
                                 Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" style=\"color:white; width:100%; \" class=\"btn btn-success accept \">Accept</div>\r\n");
#nullable restore
#line 30 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div data-id=\"");
#nullable restore
#line 33 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Index.cshtml"
                                 Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" style=\"color:white;\" class=\"btn btn-primary completed\">Order Completed</div>\r\n");
#nullable restore
#line 34 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n");
#nullable restore
#line 37 "C:\Users\HP\Desktop\final\Final-Project\Final-Project\Areas\Bussines\Views\Courier\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n");
            DefineSection("Script", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30f29d85afe38f80304c8a6a19d8b92042373c779208", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script src=""//cdn.jsdelivr.net/npm/sweetalert2@11""></script>
    <script>

        var Connection = new signalR.HubConnectionBuilder().withUrl(""/orderhub"").build()
        Connection.start()
        Connection.on(""isacceptdelivery"", function (data) {

            OrderShow(data.id)
        })
        Connection.on(""exsist"", function () {

            Swal.fire({
                icon: 'error',
                title: 'Oops...',
                text: 'Alrady Exsist Courier',

            })
            setTimeout(myfunction, 1500)
            function myfunction() {
                location.reload(true)
            }

        })
        function OrderShow(id) {
            var div = document.createElement(""div"")
            div.style.width = ""18rem""
            div.style.height = ""auto""
            div.classList.add(""card"")
            var container = document.querySelector("".row"")
            $.ajax({
                url: ""/bussines/courier/showorder"",
                data:");
                WriteLiteral(@" {
                    orderid: id
                },
                dataType: 'json',
                type: ""post"",
                success: function (data) {
                    console.log(data)
                    if (data.restuorant != null) {
                        div.innerHTML = `
                                     <ul class=""list-group list-group-flush"">
                                        <li class=""list-group-item"">Client Name ${data.appUser.fullName}</li>
                                        <li class=""list-group-item"">Restaurant Adress: ${data.restuorant.adress}</li>
                                        <li class=""list-group-item"">Adress: ${data.adress}</li>
                                        <li class=""list-group-item"">TotalPrice :${data.totalPrice}</li>
                                    </ul>
                                     <div class=""accept-delivery"">
                                         <div data-id=""${data.id}"" style=""color:white; width:100%; "" ");
                WriteLiteral(@"class=""btn btn-success accept "">Accept</div>
                                          </div>
`

                    } else {
                        div.innerHTML = `
                                     <ul class=""list-group list-group-flush"">
                                        <li class=""list-group-item"">Client Name ${data.appUser.fullName}</li>
                                        <li class=""list-group-item"">Store Adress: ${data.store.adress}</li>
                                        <li class=""list-group-item"">Adress: ${data.adress}</li>
                                        <li class=""list-group-item"">TotalPrice :${data.totalPrice}</li>
                                    </ul>
                                     <div class=""accept-delivery"">
                                         <div data-id=""${data.id}"" style=""color:white; width:100%; "" class=""btn btn-success accept "">Accept</div>
                                          </div>
`
                    }
               ");
                WriteLiteral(@"     container.appendChild(div)
                }
            })
        }

        $(document).on(""click"", "".accept"", function (e) {
            var orderid = $(e.target).attr('data-id')
            Connection.invoke(""CourierWasAppointed"", orderid)
            var a = $(this).parent()
            a.html(`<div data-id=""${orderid}"" style=""color:white;"" class=""btn btn-primary completed"" >Order Completed</div>
`)

        })

        $(document).on(""click"", "".completed"", function (e) {
            var orderid = $(e.target).attr('data-id')
            Connection.invoke(""OrderCompleted"", orderid)
            var a = $(this).parent().parent()
            a.css(""display"", ""none"")

        })


    </script>

");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
