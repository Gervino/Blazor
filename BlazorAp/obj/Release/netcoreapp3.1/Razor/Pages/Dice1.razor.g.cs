#pragma checksum "C:\Users\kouge\source\repos\BlazorAp\BlazorAp\Pages\Dice1.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "987890045ac6eb801883092756da580136081380"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kouge\source\repos\BlazorAp\BlazorAp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kouge\source\repos\BlazorAp\BlazorAp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kouge\source\repos\BlazorAp\BlazorAp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kouge\source\repos\BlazorAp\BlazorAp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kouge\source\repos\BlazorAp\BlazorAp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kouge\source\repos\BlazorAp\BlazorAp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kouge\source\repos\BlazorAp\BlazorAp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kouge\source\repos\BlazorAp\BlazorAp\_Imports.razor"
using BlazorAp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kouge\source\repos\BlazorAp\BlazorAp\_Imports.razor"
using BlazorAp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/dice1")]
    public partial class Dice1 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Roll the Dice!</h1>\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-primary");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\kouge\source\repos\BlazorAp\BlazorAp\Pages\Dice1.razor"
                                          ResetDice

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Reset Dice");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "btn btn-primary");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\kouge\source\repos\BlazorAp\BlazorAp\Pages\Dice1.razor"
                                          RollDice

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, "Roll Dice");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n<br>\r\n<br>\r\n\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "img");
            __builder.AddAttribute(14, "id", "dice0");
            __builder.AddAttribute(15, "src", 
#nullable restore
#line 11 "C:\Users\kouge\source\repos\BlazorAp\BlazorAp\Pages\Dice1.razor"
                          diceImage[0]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "img");
            __builder.AddAttribute(18, "id", "dice1");
            __builder.AddAttribute(19, "src", 
#nullable restore
#line 12 "C:\Users\kouge\source\repos\BlazorAp\BlazorAp\Pages\Dice1.razor"
                          diceImage[1]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "img");
            __builder.AddAttribute(22, "id", "dice2");
            __builder.AddAttribute(23, "src", 
#nullable restore
#line 13 "C:\Users\kouge\source\repos\BlazorAp\BlazorAp\Pages\Dice1.razor"
                          diceImage[2]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.OpenElement(25, "img");
            __builder.AddAttribute(26, "id", "dice3");
            __builder.AddAttribute(27, "src", 
#nullable restore
#line 14 "C:\Users\kouge\source\repos\BlazorAp\BlazorAp\Pages\Dice1.razor"
                          diceImage[3]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.OpenElement(29, "img");
            __builder.AddAttribute(30, "id", "dice4");
            __builder.AddAttribute(31, "src", 
#nullable restore
#line 15 "C:\Users\kouge\source\repos\BlazorAp\BlazorAp\Pages\Dice1.razor"
                          diceImage[4]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.OpenElement(33, "img");
            __builder.AddAttribute(34, "id", "dice5");
            __builder.AddAttribute(35, "src", 
#nullable restore
#line 16 "C:\Users\kouge\source\repos\BlazorAp\BlazorAp\Pages\Dice1.razor"
                          diceImage[5]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\kouge\source\repos\BlazorAp\BlazorAp\Pages\Dice1.razor"
       
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
            var val = GetDicePath(diceIndex + 1);
            diceImage[diceIndex] = val;
        }
    }

    public void RollDice()
    {
        Random rnd = new Random();
        int[] randomDice = diceArray.OrderBy(x => rnd.Next()).ToArray();

        for (int diceIndex = 0; diceIndex < diceArray.Length; diceIndex++)
        {
            var val = GetDicePath(randomDice[diceIndex]);
            diceImage[diceIndex] = val;
        }
    }

    string GetDicePath(int diceValue)
    {
        string val = $"{dicePrefix}{diceValue}{diceSuffix}";
        return val;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591