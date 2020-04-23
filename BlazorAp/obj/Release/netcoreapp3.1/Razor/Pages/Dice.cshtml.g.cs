#pragma checksum "C:\Users\kouge\source\repos\BlazorAp\BlazorAp\Pages\Dice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9de0f12065a6c93912e51916dbd6fb5cb489d4b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Dice), @"mvc.1.0.razor-page", @"/Pages/Dice.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/dice")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9de0f12065a6c93912e51916dbd6fb5cb489d4b6", @"/Pages/Dice.cshtml")]
    public class Pages_Dice : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Roll the Dice!</h1>\r\n\r\n\r\n");
            WriteLiteral("<br />\r\n<br />\r\n<div>\r\n    <img id=\"dice0\"");
            BeginWriteAttribute("src", " src=\"", 238, "\"", 257, 1);
#nullable restore
#line 11 "C:\Users\kouge\source\repos\BlazorAp\BlazorAp\Pages\Dice.cshtml"
WriteAttributeValue("", 244, diceImage[0], 244, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <img id=\"dice1\"");
            BeginWriteAttribute("src", " src=\"", 282, "\"", 301, 1);
#nullable restore
#line 12 "C:\Users\kouge\source\repos\BlazorAp\BlazorAp\Pages\Dice.cshtml"
WriteAttributeValue("", 288, diceImage[1], 288, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <img id=\"dice2\"");
            BeginWriteAttribute("src", " src=\"", 326, "\"", 345, 1);
#nullable restore
#line 13 "C:\Users\kouge\source\repos\BlazorAp\BlazorAp\Pages\Dice.cshtml"
WriteAttributeValue("", 332, diceImage[2], 332, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <img id=\"dice3\"");
            BeginWriteAttribute("src", " src=\"", 370, "\"", 389, 1);
#nullable restore
#line 14 "C:\Users\kouge\source\repos\BlazorAp\BlazorAp\Pages\Dice.cshtml"
WriteAttributeValue("", 376, diceImage[3], 376, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <img id=\"dice4\"");
            BeginWriteAttribute("src", " src=\"", 414, "\"", 433, 1);
#nullable restore
#line 15 "C:\Users\kouge\source\repos\BlazorAp\BlazorAp\Pages\Dice.cshtml"
WriteAttributeValue("", 420, diceImage[4], 420, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <img id=\"dice5\"");
            BeginWriteAttribute("src", " src=\"", 458, "\"", 477, 1);
#nullable restore
#line 16 "C:\Users\kouge\source\repos\BlazorAp\BlazorAp\Pages\Dice.cshtml"
WriteAttributeValue("", 464, diceImage[5], 464, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\kouge\source\repos\BlazorAp\BlazorAp\Pages\Dice.cshtml"
            
    int[] diceArray = new int[] { 1, 2, 3, 4, 5, 6 };
    string[] diceImage = new string[6];
    string dicePrefix = "/Img/dice";
    string diceSuffix = ".PNG";

    protected void OnInit()
    {
        ResetDice();
    }


    public void ResetDice()
    {
        for (int diceIndex = 0; diceIndex < diceArray.Length; diceIndex++)
        {
            diceImage[diceIndex] = GetDicePath(diceIndex + 1);
        }
    }

    public void RollDice()
    {
        Random rnd = new Random();
        int[] randomDice = diceArray.OrderBy(x => rnd.Next()).ToArray();

        for (int diceIndex = 0; diceIndex < diceArray.Length; diceIndex++)
        {
            diceImage[diceIndex] = GetDicePath(randomDice[diceIndex]);
        }
    }

    string GetDicePath(int diceValue)
    {
        return $"{dicePrefix}{diceValue}{diceSuffix}";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Dice> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Dice> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Dice>)PageContext?.ViewData;
        public Pages_Dice Model => ViewData.Model;
    }
}
#pragma warning restore 1591