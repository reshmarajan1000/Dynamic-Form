#pragma checksum "/Users/RajanRe/Desktop/projects/Dynamic-Form-Builder/Views/Dashboard/Templates/TemplateList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55a934a892ea127e54564dc84cacdddc02402f8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Templates_TemplateList), @"mvc.1.0.view", @"/Views/Dashboard/Templates/TemplateList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/Templates/TemplateList.cshtml", typeof(AspNetCore.Views_Dashboard_Templates_TemplateList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55a934a892ea127e54564dc84cacdddc02402f8b", @"/Views/Dashboard/Templates/TemplateList.cshtml")]
    public class Views_Dashboard_Templates_TemplateList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/RajanRe/Desktop/projects/Dynamic-Form-Builder/Views/Dashboard/Templates/TemplateList.cshtml"
  
    ViewBag.Title = "Dashboard's Template Selection";

#line default
#line hidden
            BeginContext(59, 949, true);
            WriteLiteral(@"
<!-- Content Header (Page header) -->
<section class=""content-header"">
    <h1>
        Dynamic Form Creation
    </h1>
</section>
<div class=""setDataWrap"">
    <button id=""getXML"" type=""button"">Save Form</button>
</div>
<div id=""build-wrap""></div>

<form id=""fb-render""></form>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.4/jquery.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.11.4/jquery-ui.min.js""></script>
<script src=""https://formbuilder.online/assets/js/form-builder.min.js""></script>
<script>
    jQuery(function ($) {
        var fbEditor = document.getElementById('build-wrap');
        var formBuilder = $(fbEditor).formBuilder();
        var dt = new Date();

        document.getElementById('getXML').addEventListener('click', function () {
        var savedFormData = formBuilder.actions.getData('xml');
     
        $.ajax(
        {
            type: ""POST"",
            url: '");
            EndContext();
            BeginContext(1009, 39, false);
#line 32 "/Users/RajanRe/Desktop/projects/Dynamic-Form-Builder/Views/Dashboard/Templates/TemplateList.cshtml"
             Write(Url.Action("SaveFormData", "Dashboard"));

#line default
#line hidden
            EndContext();
            BeginContext(1048, 611, true);
            WriteLiteral(@"',
            data: {
                FormName: localStorage.getItem(""form_name""),
                FormData: savedFormData,
                CreatedData: dt
            },
            error: function (result) {
                alert(""error saveform"");
            },
                success: function (result) {
 

                if (result != ""False"") {
                    window.location = ""/Dashboard/TemplateList/"";
                }
                else {
                    alert(""There is a Problem in saving Form Data!"");
                }
            }
        });


        });
    });

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
