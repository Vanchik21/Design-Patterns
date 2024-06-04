using CompositeLib;
using System;

namespace YourNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            var html = new LightElementNode("html", (int)DisplayType.Block, (int)IsPaired.Paired);
            var head = new LightElementNode("head", (int)DisplayType.Block, (int)IsPaired.Paired);
            var body = new LightElementNode("body", (int)DisplayType.Block, (int)IsPaired.Paired);

            var titleHead = new LightElementNode("title", (int)DisplayType.Block, (int)IsPaired.Paired);
            var textTitleHead = new LightTextNode("Title");
            titleHead.AddChild(textTitleHead);
            head.AddChild(titleHead);

            var p = new LightElementNode("p", (int)DisplayType.Block, (int)IsPaired.Paired);
            p.AddCSS("color: red;");
            p.AddCSS("background-color: yellow;");
            var textFirstP = new LightTextNode("Text1");
            var span = new LightElementNode("span", (int)DisplayType.String, (int)IsPaired.Paired);
            var textSpan = new LightTextNode("Text Span");
            span.AddChild(textSpan);
            var textSecondP = new LightTextNode("Text2");
            p.AddChild(textFirstP);
            p.AddChild(span);
            p.AddChild(textSecondP);

            var br = new LightElementNode("br", (int)DisplayType.String, (int)IsPaired.Unpaired);

            body.AddChild(p);
            body.AddChild(br);

            html.AddChild(head);
            html.AddChild(body);

            html.OutterLightHTML();

            Console.WriteLine("\n----------------------------\n");

            p.RemoveCss("color: red;");
            p.RemoveChild(textSecondP);

            html.OutterLightHTML();

            Console.WriteLine("\n----------------------------\n");

            br.AddChild(textSecondP);

            html.OutterLightHTML();
        }
    }
}
