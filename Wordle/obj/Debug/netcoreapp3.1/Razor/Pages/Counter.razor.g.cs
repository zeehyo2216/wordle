#pragma checksum "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1ed5ff1fd419fc7f047de8e5c592de64de1ba9e"
// <auto-generated/>
#pragma warning disable 1591
namespace Wordle.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\zeehyo\Wordle\Wordle\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\zeehyo\Wordle\Wordle\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\zeehyo\Wordle\Wordle\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\zeehyo\Wordle\Wordle\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\zeehyo\Wordle\Wordle\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\zeehyo\Wordle\Wordle\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\zeehyo\Wordle\Wordle\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\zeehyo\Wordle\Wordle\_Imports.razor"
using Wordle;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\zeehyo\Wordle\Wordle\_Imports.razor"
using Wordle.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/wordle")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    span {
        font-size: 21px;
        text-decoration-line: underline;
        text-decoration-thickness: 5px;
    }
    p{
        font-size: 21px;
    }
    .box {
        font-family: ""nyt-franklin"";
        width: 24px;
        display: inline-flex;
        justify-content: center;
        align-items: center;
        font-size: 2rem;
        line-height: 1;
        font-weight: bold;
        vertical-align: middle;
        box-sizing: border-box;
        text-transform: uppercase;
    }
</style>

");
            __builder.AddMarkupContent(1, "<h1>Wordle by ZeeHyo</h1>\r\n");
            __builder.AddMarkupContent(2, "<h3> - for 해연</h3>\r\n\r\n");
            __builder.AddMarkupContent(3, "<p>Welcome to the word guessing game!</p>\r\n");
            __builder.AddMarkupContent(4, "<p>Guess a five-letter word:</p>\r\n");
            __builder.OpenElement(5, "form");
            __builder.AddAttribute(6, "onsubmit", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 35 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
                 PlayGame

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "placeholder", "Insert word.");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
                                                   guess

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => guess = __value, guess));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "style", "display:" + " " + (
#nullable restore
#line 37 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
                             display

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "class", "btn btn-primary");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
                                                                        PlayGame

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "Guess!");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "style", "display:" + " " + (
#nullable restore
#line 38 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
                             display2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "class", "btn btn-primary");
            __builder.AddAttribute(22, "onClick", "window.location.reload()");
            __builder.AddContent(23, "New Game!");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n\r\n");
            __builder.OpenElement(26, "p");
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.AddMarkupContent(28, "<p>Trial 1:</p>\r\n");
#nullable restore
#line 44 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
     foreach (var feedback in feedback1)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "        ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "box");
            __builder.AddAttribute(32, "style", "background-color:" + " " + (
#nullable restore
#line 46 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
                                                   feedback.Color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, 
#nullable restore
#line 46 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
                                                                    feedback.Letter

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 47 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
            __builder.OpenElement(36, "p");
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.AddMarkupContent(38, "<p>Trial 2:</p>\r\n");
#nullable restore
#line 51 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
     foreach (var feedback in feedback2)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, "        ");
            __builder.OpenElement(40, "span");
            __builder.AddAttribute(41, "style", "color:" + " " + (
#nullable restore
#line 53 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
                             feedback.Color

#line default
#line hidden
#nullable disable
            ) + ";" + " text-decoration-color:" + " " + (
#nullable restore
#line 53 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
                                                                     feedback.Color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(42, 
#nullable restore
#line 53 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
                                                                                      feedback.Letter

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 54 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
            __builder.OpenElement(45, "p");
            __builder.AddMarkupContent(46, "\r\n     ");
            __builder.AddMarkupContent(47, "<p>Trial 3:</p>\r\n");
#nullable restore
#line 58 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
     foreach (var feedback in feedback3)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "        ");
            __builder.OpenElement(49, "span");
            __builder.AddAttribute(50, "style", "color:" + " " + (
#nullable restore
#line 60 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
                             feedback.Color

#line default
#line hidden
#nullable disable
            ) + ";" + " text-decoration-color:" + " " + (
#nullable restore
#line 60 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
                                                                     feedback.Color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(51, 
#nullable restore
#line 60 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
                                                                                      feedback.Letter

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 61 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
            __builder.OpenElement(54, "p");
            __builder.AddMarkupContent(55, "\r\n    ");
            __builder.AddMarkupContent(56, "<p>Trial 4:</p>\r\n");
#nullable restore
#line 65 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
     foreach (var feedback in feedback4)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(57, "        ");
            __builder.OpenElement(58, "span");
            __builder.AddAttribute(59, "style", "color:" + " " + (
#nullable restore
#line 67 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
                             feedback.Color

#line default
#line hidden
#nullable disable
            ) + ";" + " text-decoration-color:" + " " + (
#nullable restore
#line 67 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
                                                                     feedback.Color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(60, 
#nullable restore
#line 67 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
                                                                                      feedback.Letter

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n");
#nullable restore
#line 68 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n");
            __builder.OpenElement(63, "p");
            __builder.AddMarkupContent(64, "\r\n    ");
            __builder.AddMarkupContent(65, "<p>Trial 5:</p>\r\n");
#nullable restore
#line 72 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
     foreach (var feedback in feedback5)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(66, "        ");
            __builder.OpenElement(67, "span");
            __builder.AddAttribute(68, "style", "color:" + " " + (
#nullable restore
#line 74 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
                             feedback.Color

#line default
#line hidden
#nullable disable
            ) + ";" + " text-decoration-color:" + " " + (
#nullable restore
#line 74 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
                                                                     feedback.Color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(69, 
#nullable restore
#line 74 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
                                                                                      feedback.Letter

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n");
#nullable restore
#line 75 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n");
            __builder.OpenElement(72, "p");
            __builder.AddContent(73, 
#nullable restore
#line 77 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
    end

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
       
    public class Feedback
    {
        public char Letter { get; }
        public string Color { get; }

        public Feedback(char letter, string color)
        {
            Letter = letter;
            Color = color;
        }
    }

    private static readonly Random Random = new Random();

    private static string GenerateWord()
    {
        var words = File.ReadAllLines("./Pages/wordlist.txt");
        return words[Random.Next(words.Length)];
    }

    private static bool CheckWord(string word)
    {
        var words = File.ReadAllLines("./Pages/wordlist.txt");
        bool check = words.Any(w => w == word);

        return check;
    }

    private static Feedback[] CheckGuess(string word, string guess)
    {
        //var words1 = File.ReadAllLines("./Pages/wordlist.txt");
        if (word.Length != 5) return null;
        if (guess.Length != 5) return null;
        //if (!(words1.Contains(word))) return null;
        if (!CheckWord(guess)) return null;
        var result = new Feedback[word.Length];
        for (int i = 0; i < word.Length; i++)
        {
            if (guess[i] == word[i])
            {
                result[i] = new Feedback(guess[i], "#82E0AA");
            }
            else if (word.Contains(guess[i]))
            {
                result[i] = new Feedback(guess[i], "#F4D03F");
            }
            else
            {
                result[i] = new Feedback(guess[i], "white");
            }
        }
        return result;
    }

    //public string word = "skull";
    public string word = GenerateWord().Trim();
    public bool h = CheckWord("apple");
    public string guess;
    public int trial = 0;

    //Feedback def = new Feedback(' ', "black");

    Feedback[] feedback1 = new Feedback[] { new Feedback(' ', "black") };
    Feedback[] feedback2 = new Feedback[] { new Feedback(' ', "black") };
    Feedback[] feedback3 = new Feedback[] { new Feedback(' ', "black") };
    Feedback[] feedback4 = new Feedback[] { new Feedback(' ', "black") };
    Feedback[] feedback5 = new Feedback[] { new Feedback(' ', "black") };
    public string end;

    public string display = "inliine";
    public string display2 = "none";

    private void PlayGame()
    {
        if (guess == null) { return; }
        //var feedlist = new[] { feedback1, feedback2, feedback3, feedback4, feedback5 };
        var feedback = CheckGuess(word, guess);
        if (feedback == null)
        {
            end = "Invalid word. Check the number of letters.";
            return;
        }
        end = "";
        switch (trial)
        {
            case 0:
                feedback1 = feedback;
                break;
            case 1:
                feedback2 = feedback;
                break;
            case 2:
                feedback3 = feedback;
                break;
            case 3:
                feedback4 = feedback;
                break;
            case 4:
                feedback5 = feedback;
                break;
        }
        trial++;
        guess = null;
        if (trial > 4)
        {
            end = "Sorry, you ran out of guesses. The word was " + word;
            display = "none";
            display2 = "inliine";
        }

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 198 "D:\zeehyo\Wordle\Wordle\Pages\Counter.razor"
           

    if (feedback.All(x => x.Color == "#82E0AA"))
    {
        end = "Congratulations, you guessed the word within " + trial + " trials!";
        display = "none";
        display2 = "inliine";
        return;
    }
}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
