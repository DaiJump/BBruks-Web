#pragma checksum "C:\Users\daisa\source\repos\Bbruks_Web\Bbruks_Web\Views\Profile\Perfil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea9395b4e51f21015f6ae94727624ba1639b9e81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Perfil), @"mvc.1.0.view", @"/Views/Profile/Perfil.cshtml")]
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
#line 1 "C:\Users\daisa\source\repos\Bbruks_Web\Bbruks_Web\Views\_ViewImports.cshtml"
using Bbruks_Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\daisa\source\repos\Bbruks_Web\Bbruks_Web\Views\_ViewImports.cshtml"
using Bbruks_Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea9395b4e51f21015f6ae94727624ba1639b9e81", @"/Views/Profile/Perfil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbe81429584bef6ce8187a14d96bfe36a48f7cb4", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Perfil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\daisa\source\repos\Bbruks_Web\Bbruks_Web\Views\Profile\Perfil.cshtml"
  
    ViewData["Title"] = "Perfil";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<header>\r\n    <nav class=\"navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow mb-3\">\r\n        <div class=\"container\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea9395b4e51f21015f6ae94727624ba1639b9e815831", async() => {
                WriteLiteral("BBruks");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target="".navbar-collapse"" aria-controls=""navbarSupportedContent""
                    aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""navbar-collapse collapse d-sm-inline-flex"">
                <div class=""navbar-collapse collapse d-sm-inline-flex"">
                    <ul class=""navbar-nav flex-grow-1"">
                    </ul>

                    <ul class=""navbar-nav"">

                        <li class=""nav-item"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea9395b4e51f21015f6ae94727624ba1639b9e818158", async() => {
                WriteLiteral("Inicio");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n\r\n                        <li class=\"nav-item\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea9395b4e51f21015f6ae94727624ba1639b9e819918", async() => {
                WriteLiteral("Cerrar Sesi??n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n                    </ul>\r\n\r\n\r\n                </div>\r\n            </div>\r\n    </nav>\r\n</header>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea9395b4e51f21015f6ae94727624ba1639b9e8111714", async() => {
                WriteLiteral(@"
    <div class=""container"">
        <div class=""main-body"">
            <div class=""row"">
                <div class=""col-lg-4"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <div class=""d-flex flex-column align-items-center text-center"">
                                <img src=""https://bootdey.com/img/Content/avatar/avatar6.png"" alt=""Admin"" class=""rounded-circle p-1 bg-primary"" width=""110"">
                                <div class=""mt-3"">
                                    <h4>Victor</h4>
                                    <p class=""text-secondary mb-1"">victoruser123</p>
                                    <p class=""text-muted font-size-sm"">victor@gmail.com</p>
                                    <p class=""text-muted font-size-sm"">Activo desde: 17/05/2021</p>
                                    <button class=""btn btn-outline-danger"">Suspender cuenta</button>
                                </div>
                      ");
                WriteLiteral(@"      </div>
                            <hr class=""my-4"">
                            <ul class=""list-group list-group-flush"">
                                <li class=""list-group-item d-flex justify-content-between align-items-center flex-wrap"">
                                    <h6 class=""mb-0"">OPCION 1</h6>
                                </li>
                                <li class=""list-group-item d-flex justify-content-between align-items-center flex-wrap"">
                                    <h6 class=""mb-0"">OPCION 2</h6>
                                </li>
                                <li class=""list-group-item d-flex justify-content-between align-items-center flex-wrap"">
                                    <h6 class=""mb-0"">OPCION 3</h6>
                                </li>
                                <li class=""list-group-item d-flex justify-content-between align-items-center flex-wrap"">
                                    <h6 class=""mb-0"">OPCION 4</h6>
                ");
                WriteLiteral(@"                </li>
                                <li class=""list-group-item d-flex justify-content-between align-items-center flex-wrap"">
                                    <h6 class=""mb-0"">OPCION 5</h6>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-sm-12"">
                        <div class=""card"">
                            <div class=""card-body"">
                                <h5 class=""d-flex align-items-center mb-3"">Mis favoritos</h5>
                                <div class=""tab-content"">
                                    <div class=""tab-pane active"" id=""home"">
                                        <div class=""table-responsive"">
                                            <table class=""table table-hover"">
                                                <thead>
                                     ");
                WriteLiteral(@"               <tr>
                                                        <th>#</th>
                                                        <th>Titulo</th>
                                                        <th>Autor</th>
                                                        <th>Fecha de consulta</th>
                                                    </tr>
                                                </thead>
                                                <tbody id=""items"">
                                                    <tr>
                                                        <td>1</td>
                                                        <td>Libro 1</td>
                                                        <td>Autor 1</td>
                                                        <td>05/05/2021</td>
                                                    </tr>
                                                    <tr>
                                                     ");
                WriteLiteral(@"   <td>2</td>
                                                        <td>Libro 2</td>
                                                        <td>Autor 2</td>
                                                        <td>05/05/2021</td>
                                                    </tr>
                                                    <tr>
                                                        <td>3</td>
                                                        <td>Libro 3</td>
                                                        <td>Autor 3</td>
                                                        <td>06/05/2021</td>
                                                    </tr>
                                                    <tr>
                                                        <td>4</td>
                                                        <td>Libro 4</td>
                                                        <td>Autor 4</td>
                                         ");
                WriteLiteral(@"               <td>06/05/2021</td>
                                                    </tr>
                                                    <tr>
                                                        <td>5</td>
                                                        <td>Libro 5</td>
                                                        <td>Autor 5</td>
                                                        <td>07/05/2021</td>
                                                    </tr>
                                                    <tr>
                                                        <td>6</td>
                                                        <td>Libro 6</td>
                                                        <td>Autor 6</td>
                                                        <td>07/05/2021</td>
                                                    </tr>
                                                    <tr>
                                                   ");
                WriteLiteral(@"     <td>7</td>
                                                        <td>Libro 7</td>
                                                        <td>Autor 7</td>
                                                        <td>07/05/2021</td>
                                                    </tr>
                                                    <tr>
                                                        <td>8</td>
                                                        <td>Libro 8</td>
                                                        <td>Autor 8</td>
                                                        <td>09/05/2021</td>
                                                    </tr>
                                                    <tr>
                                                        <td>9</td>
                                                        <td>Libro 9</td>
                                                        <td>Autor 9</td>
                                       ");
                WriteLiteral(@"                 <td>09/05/2021</td>
                                                    </tr>
                                                    <tr>
                                                        <td>10</td>
                                                        <td>Libro 10</td>
                                                        <td>Autor 10</td>
                                                        <td>09/05/2021</td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                            <hr>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class=""row"">
                            <div class=""col-sm-12"">
                                <div class=""card"">
  ");
                WriteLiteral(@"                                  <div class=""card-body"">
                                        <h5 class=""d-flex align-items-center mb-3"">Mis B??squedas Recientes</h5>
                                        <div class=""tab-content"">
                                            <div class=""tab-pane active"" id=""home"">
                                                <div class=""table-responsive"">
                                                    <table class=""table table-hover"">
                                                        <thead>
                                                            <tr>
                                                                <th>#</th>
                                                                <th>Titulo</th>
                                                                <th>Autor</th>
                                                                <th>Fecha de consulta</th>
                                                            </tr>
      ");
                WriteLiteral(@"                                                  </thead>
                                                        <tbody id=""items"">
                                                            <tr>
                                                                <td>1</td>
                                                                <td>Libro 1</td>
                                                                <td>Autor 1</td>
                                                                <td>05/05/2021</td>
                                                            </tr>
                                                            <tr>
                                                                <td>2</td>
                                                                <td>Libro 2</td>
                                                                <td>Autor 2</td>
                                                                <td>05/05/2021</td>
                                       ");
                WriteLiteral(@"                     </tr>
                                                            <tr>
                                                                <td>3</td>
                                                                <td>Libro 3</td>
                                                                <td>Autor 3</td>
                                                                <td>06/05/2021</td>
                                                            </tr>
                                                            <tr>
                                                                <td>4</td>
                                                                <td>Libro 4</td>
                                                                <td>Autor 4</td>
                                                                <td>06/05/2021</td>
                                                            </tr>
                                                            <tr>
              ");
                WriteLiteral(@"                                                  <td>5</td>
                                                                <td>Libro 5</td>
                                                                <td>Autor 5</td>
                                                                <td>07/05/2021</td>
                                                            </tr>
                                                            <tr>
                                                                <td>6</td>
                                                                <td>Libro 6</td>
                                                                <td>Autor 6</td>
                                                                <td>07/05/2021</td>
                                                            </tr>
                                                            <tr>
                                                                <td>7</td>
                                              ");
                WriteLiteral(@"                  <td>Libro 7</td>
                                                                <td>Autor 7</td>
                                                                <td>07/05/2021</td>
                                                            </tr>
                                                            <tr>
                                                                <td>8</td>
                                                                <td>Libro 8</td>
                                                                <td>Autor 8</td>
                                                                <td>09/05/2021</td>
                                                            </tr>
                                                            <tr>
                                                                <td>9</td>
                                                                <td>Libro 9</td>
                                                                <td>Auto");
                WriteLiteral(@"r 9</td>
                                                                <td>09/05/2021</td>
                                                            </tr>
                                                            <tr>
                                                                <td>10</td>
                                                                <td>Libro 10</td>
                                                                <td>Autor 10</td>
                                                                <td>09/05/2021</td>
                                                            </tr>
                                                        </tbody>
                                                    </table>
                                                    <hr>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
               ");
                WriteLiteral("                 </div>\r\n\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
