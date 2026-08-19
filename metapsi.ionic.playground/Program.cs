using Metapsi;
using Metapsi.Html;
using Metapsi.Ionic;
using Metapsi.Syntax;
using Metapsi.Web;

public static class Program
{
    public static async Task Main()
    {
        var builder = WebApplication.CreateBuilder();
        builder.AddMetapsi();
        var app = builder.Build();
        app.UseMetapsi();


        app.MapGet("/", async () =>
        {
            return MetapsiHttpResult.Result(HtmlBuilder.FromDefault(b =>
            {
                b.BodyAppend(b.IonApp(b.IonNav()));
                b.BodyAppend(b.HtmlScriptModule(
                    b =>
                    {
                        var unattachedDiv = b.CreateElement<HtmlDiv>(
                            "div",
                            b =>
                            {

                            },
                            b.CreateElement<IonContent>(
                                "ion-content",
                                b=>
                                {

                                },
                                b.CreateElement<IonIcon>(
                                    "ion-icon",
                                    b =>
                                    {
                                        b.SetProperty(b.Const("name"), b.Const("home-outline"));
                                        b.SetProperty(b.Const("size"), b.Const("large"));
                                    }),
                                b.CreateTextNode("Hello World"))).As<HTMLElement>();

                        var ionNav = b.QuerySelector("ion-nav").As<IonNav>();
                        b.On(ionNav, b =>
                        {
                            b.setRoot(
                                unattachedDiv, done: b.Def((SyntaxBuilder b, Var<bool> firstValue, Var<bool> secondValue, Var<ViewController> viewController1) =>
                                {
                                    b.Log("first value", firstValue);
                                    b.Log("second value ", secondValue);
                                    b.Log("viewController1 ", viewController1);
                                }).As<Action<bool, bool, ViewController, ViewController, string>>());
                        });
                    }));
            }));
        });

        await app.RunAsync();
    }
}

public class Model
{

}

public static class Playground
{
    //public static void Render(Model model, HtmlWriter w)
    //{
    //    w.Div("Hello World");
    //}
}