#pragma checksum "C:\Users\John\Documents\Visual_Studio_C#\Pages\About_Me.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "468683ea11d14b415972da0fb0b15a6a99cd5e02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Visual_Studio_C_.Pages.Pages_About_Me), @"mvc.1.0.razor-page", @"/Pages/About_Me.cshtml")]
namespace Visual_Studio_C_.Pages
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
#line 1 "C:\Users\John\Documents\Visual_Studio_C#\Pages\_ViewImports.cshtml"
using Visual_Studio_C_;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"468683ea11d14b415972da0fb0b15a6a99cd5e02", @"/Pages/About_Me.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0ff7ade2ce4493a87370a036cbc70bda4d1581c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_About_Me : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\John\Documents\Visual_Studio_C#\Pages\About_Me.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">AboutMe</h1>
    <p>Here are some things about me that I would like to talk about</a>.</p>

    <p>Been coding since 2016 and have been always curious about how programs work.</p>

    <img src =""Me.jpg"" alt=""CoolGuy"" />

    <p>This Website will demonstrate some things that interest me and some programs that I've worked on.</p>
    
    <ol>
        <li>Caffeine Killer is one of my favorite programs I've written as I'm a big coffee guy. I wrote these in multiple languages so I can use a reference on the syntax for each.</li> <br>

        <li>I've worked with C, C++, and C# in the past. I've taken a C class at CCAC, along with C++ with Data Structures. I've dabbled in C# here and there, and now I'm gonna utilize it to its extent</li> <br>

        <li>On this page, I plan to make a basic music player where the user will select a file and play a file. </li> <br>

        <li>I'm gonna demonstrate linked lists and display a string on the fr");
            WriteLiteral("ont end. </li>\r\n\r\n    </ol>\r\n\r\n\r\n<img src =\"Pictures/Coffee.jpg\" alt=\"Coffee\">\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
