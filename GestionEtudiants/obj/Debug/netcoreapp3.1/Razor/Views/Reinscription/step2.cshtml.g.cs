#pragma checksum "C:\Users\user\Source\Repos\AdminApp\GestionEtudiants\Views\Reinscription\step2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9321634b4dc74db587253fe886957931456c11a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reinscription_step2), @"mvc.1.0.view", @"/Views/Reinscription/step2.cshtml")]
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
#line 1 "C:\Users\user\Source\Repos\AdminApp\GestionEtudiants\Views\_ViewImports.cshtml"
using GestionEtudiants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Source\Repos\AdminApp\GestionEtudiants\Views\_ViewImports.cshtml"
using GestionEtudiants.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9321634b4dc74db587253fe886957931456c11a3", @"/Views/Reinscription/step2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bd42f6c58abe4c00cf52c3386a3b7da9e342007", @"/Views/_ViewImports.cshtml")]
    public class Views_Reinscription_step2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Etudiant>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Ma", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Et", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reinscription", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "step1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn--radius-2 btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\user\Source\Repos\AdminApp\GestionEtudiants\Views\Reinscription\step2.cshtml"
   Layout = ""; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9321634b4dc74db587253fe886957931456c11a35897", async() => {
                WriteLiteral(@"
    <!-- Required meta tags-->
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <meta name=""description"" content=""Colorlib Templates"">
    <meta name=""author"" content=""Colorlib"">
    <meta name=""keywords"" content=""Colorlib Templates"">

    <!-- Title Page-->
    <title>Inscription et Réinscription en ligne - eEnsas</title>

    <!-- Icons font CSS-->
    <link href=""../colorlib-regform-5/vendor/mdi-font/css/material-design-iconic-font.min.css"" rel=""stylesheet"" media=""all"">
    <link href=""../colorlib-regform-5/vendor/font-awesome-4.7/css/font-awesome.min.css"" rel=""stylesheet"" media=""all"">
    <!-- Font special for pages-->
    <link href=""https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i,800,800i"" rel=""stylesheet"">

    <!-- Vendor CSS-->
    <link href=""../colorlib-regform-5/vendor/select2/select2.min.css"" rel=""stylesheet"" media=""all"">
    <link href=""../colorlib-regform-5/vendor/d");
                WriteLiteral(@"atepicker/daterangepicker.css"" rel=""stylesheet"" media=""all"">
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"" integrity=""sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh"" crossorigin=""anonymous"">
    <script src=""https://code.jquery.com/jquery-3.4.1.slim.min.js"" integrity=""sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n"" crossorigin=""anonymous""></script>
<script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>
<link rel=""stylesheet"" type=""text/css"" href=""http://www.arabic-keyboard.org/keyboard/keyboard.css""> 
    <script type=""text/javascript"" src=""http://www.");
                WriteLiteral("arabic-keyboard.org/keyboard/keyboard.js\" charset=\"UTF-8\"></script> \r\n    <!-- Main CSS-->\r\n    <link href=\"../assets/styles/test.css\" rel=\"stylesheet\" media=\"all\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9321634b4dc74db587253fe886957931456c11a39245", async() => {
                WriteLiteral(@"
    <div class=""page-wrapper bg-gra-03 p-t-45 p-b-50"">
        <div class=""wrapper wrapper--w780"">
            <div class=""card card-5"">
                <div class=""card-heading"">
                <h2 class=""title"">Formulaire d'inscription en ligne </h2>
<br>
<div class=""row"">
    <div class=""col-lg-3 col-md-2""></div>
    <div class=""col-lg-6 col-md-8"">
        <div class=""progress"" style=""height: 20px;"">
            <div class=""progress-bar btn--blue progress-bar-striped active"" role=""progressbar""
                 area-valuemin=""1"" area-valuemax=""5"" aria-valuenow=""2"" style=""width: 40%;"">
                <strong>Etape2</strong>
            </div>
        </div>
    </div>
    <div class=""col-lg-3 col-md-2""></div>
</div>
                </div>
                <div class=""card-body"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9321634b4dc74db587253fe886957931456c11a310370", async() => {
                    WriteLiteral(@"
                        <div class=""form-row m-b-50"">
                            <div class=""name"">Nom </div>
                            <div class=""value"">
                                <div class=""row row-space"">
                                    <div class=""col-6"">
                                        <div class=""input-group-desc"">
                                            <input class=""input--style-5"" type=""text"" id=""nom_fr"" name=""nom_fr""  placeholder=""Nom en francais"">
                                        </div>
                                    </div>
                                    <div class=""col-6"">
                                        <div class=""input-group-desc"">
                                            <input class=""input--style-5 keyboardInput"" type=""text"" id=""nom_ar"" name=""nom_ar""   placeholder="" الإسم العائلي بالعربية  ""  dir=""rtl"" required>


                                        </div>
                                    </div>
                  ");
                    WriteLiteral(@"                 
                                </div>
                            </div>
                        </div>
                     
                        <div class=""form-row m-b-50"">
                            <div class=""name"">Prenom </div>
                            <div class=""value"">
                                <div class=""row row-space"">
                                    <div class=""col-6"">
                                        <div class=""input-group-desc"">
                                            <input class=""input--style-5"" type=""text"" id=""prenom_fr"" name=""prenom_fr"" placeholder=""Prenom en francais"">
                                        </div>
                                    </div>
                                    <div class=""col-6"">
                                        <div class=""input-group-desc"" >
                                            <input class=""input--style-5 keyboardInput"" type=""text"" id=""prenom_ar"" name=""prenom_ar""  dir=""rtl"" p");
                    WriteLiteral(@"laceholder=""الإسم الشخصي بالعربية""required>


                                        </div>
                                    </div>
                                   
                                </div>
                            </div>
                        </div>

                        <div class=""form-row m-b-50"">
                             <div class=""name"">Naissance</div>

                            <div class=""value"">
                                <div class=""row row-space"">
                                    <div class=""col-6"">
                                    <div class=""input-group-desc"">
                                    <input class=""input--style-5 js-datepicker"" type=""text"" placeholder=""Date de naissance"" id=""ddn"" name=""ddn"" >
                                </div>
                                    </div>
                                    <div class=""col-6"">
                                        <div class=""input-group-desc"" >
                   ");
                    WriteLiteral(@"                         <input class=""input--style-5"" type=""text"" id=""ldn"" name=""ldn"" placeholder= ""Lieu de naissance"" required>


                                        </div>
                                    </div>
                                   
                                </div>
                            </div>
                        </div>
                        
                        <div class=""form-row m-b-50"">
                            <div class=""name"">Téléphone</div>
                            <div class=""value"">
                                <div class=""row row-space"">
                                    <div class=""col-6"">
                                    <div class=""rs-select2 js-select-simple select--no-search"">
                                    <select name=""natio"" id=""natio""  required>                                  
                                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9321634b4dc74db587253fe886957931456c11a314884", async() => {
                        WriteLiteral("Nationalité");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9321634b4dc74db587253fe886957931456c11a316666", async() => {
                        WriteLiteral("Marocaine");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9321634b4dc74db587253fe886957931456c11a317993", async() => {
                        WriteLiteral("Etrangère");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                                </select>
                                        <div class=""select-dropdown""></div>
                                    </div>
                                    </div>
                                    <div class=""col-6"">
                                        <div class=""input-group-desc"" >
                                            <input class=""input--style-5 "" type=""tel""  id=""phone"" name=""phone""  placeholder=""Téléphone"" required>

                                        </div>
                                    </div>
                                   
                                </div>
                            </div>
                        </div>

                        <div class=""form-row"">
                            <div class=""name"">Adresse</div>
                            <div class=""value"">
                                <div class=""input-group"">
                                    <input class=""input--style-5"" type=""text""  ");
                    WriteLiteral(@" name=""address"" id=""address"" placeholder =""Adresse de résidence (complète)"">
                                </div>
                            </div>
                        </div>

                        <div class=""form-row m-b-50"">
                        <div class=""name""> sexe </div>
                        <div class=""value"">
                                <div class=""row row-space"">
                                    <div class=""col-6"">
                                <label class=""radio-container m-r-55"">Male
                                    <input type=""radio"" checked=""checked"" id = ""sexe"" name= ""sexe"" value =""M"">
                                    <span class=""checkmark""></span>
                                </label>
</div>
<div class=""col-6"">

                                <label class=""radio-container"">Femelle
                                    <input type=""radio"" id = ""sexe"" name= ""sexe"" value =""F"">
                                    <span class=""checkmark""></span");
                    WriteLiteral(@">
                                </label>
                            </div>
                        </div>
</div></div>
                        


                
<div class=""form-row m-b-50"">
                            <div class=""name"">  </div>
                    <div class=""value"">
                        <div class=""row row-space"">
                            <div class=""col-6"">
                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9321634b4dc74db587253fe886957931456c11a321928", async() => {
                        WriteLiteral("Précédent");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                            </div>

                            <div class=""col-6"">
                                <button type=""submit"" class=""btn btn--radius-2 btn--blue"" >Suivant</button>
                            </div>
                        </div>
                  </div>
</div>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>

    <!-- Jquery JS-->
    <script src=""../colorlib-regform-5/vendor/jquery/jquery.min.js""></script>
    <!-- Vendor JS-->
    <script src=""../colorlib-regform-5/vendor/select2/select2.min.js""></script>
    <script src=""../colorlib-regform-5/vendor/datepicker/moment.min.js""></script>
    <script src=""../colorlib-regform-5/vendor/datepicker/daterangepicker.js""></script>

    <!-- Main JS-->
    <script src=""../colorlib-regform-5/js/global.js""></script>

");
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
            WriteLiteral("<!-- This templates was made by Colorlib (https://colorlib.com) -->\r\n\r\n</html>\r\n<!-- end document-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Etudiant> Html { get; private set; }
    }
}
#pragma warning restore 1591