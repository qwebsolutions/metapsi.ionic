using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonInfiniteScrollContent
{

    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public string loadingSpinner { get; set; }

    /// <summary>
    /// Optional text to display while loading. `loadingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `&lt;Ionic&gt;` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public object loadingText { get; set; }

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
    }
}
public static partial class IonInfiniteScrollContentControl
{
    /// <summary>
    /// Builds a "ion-infinite-scroll-content" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonInfiniteScrollContent(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonInfiniteScrollContent>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-infinite-scroll-content", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-infinite-scroll-content" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonInfiniteScrollContent(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-infinite-scroll-content", children);
    }

    /// <summary>
    /// Builds a "ion-infinite-scroll-content" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonInfiniteScrollContent(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonInfiniteScrollContent>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-infinite-scroll-content", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-infinite-scroll-content" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonInfiniteScrollContent(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-infinite-scroll-content", children);
    }

    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerBubbles(this Metapsi.Html.AttributesBuilder<IonInfiniteScrollContent> b)
    {
        b.SetAttribute("loading-spinner", "bubbles");
    }

    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerCircles(this Metapsi.Html.AttributesBuilder<IonInfiniteScrollContent> b)
    {
        b.SetAttribute("loading-spinner", "circles");
    }

    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerCircular(this Metapsi.Html.AttributesBuilder<IonInfiniteScrollContent> b)
    {
        b.SetAttribute("loading-spinner", "circular");
    }

    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerCrescent(this Metapsi.Html.AttributesBuilder<IonInfiniteScrollContent> b)
    {
        b.SetAttribute("loading-spinner", "crescent");
    }

    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerDots(this Metapsi.Html.AttributesBuilder<IonInfiniteScrollContent> b)
    {
        b.SetAttribute("loading-spinner", "dots");
    }

    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerLines(this Metapsi.Html.AttributesBuilder<IonInfiniteScrollContent> b)
    {
        b.SetAttribute("loading-spinner", "lines");
    }

    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerLinesSmall(this Metapsi.Html.AttributesBuilder<IonInfiniteScrollContent> b)
    {
        b.SetAttribute("loading-spinner", "lines-small");
    }

    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerLinesSharp(this Metapsi.Html.AttributesBuilder<IonInfiniteScrollContent> b)
    {
        b.SetAttribute("loading-spinner", "lines-sharp");
    }

    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerLinesSharpSmall(this Metapsi.Html.AttributesBuilder<IonInfiniteScrollContent> b)
    {
        b.SetAttribute("loading-spinner", "lines-sharp-small");
    }

    /// <summary>
    /// Optional text to display while loading. `loadingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `&lt;Ionic&gt;` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetLoadingText(this Metapsi.Html.AttributesBuilder<IonInfiniteScrollContent> b, string loadingText)
    {
        b.SetAttribute("loading-text", loadingText);
    }
    /// <summary>
    /// Builds a virtual "ion-infinite-scroll-content" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonInfiniteScrollContent(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonInfiniteScrollContent>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-infinite-scroll-content", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-infinite-scroll-content" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonInfiniteScrollContent(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-infinite-scroll-content", children);
    }

    /// <summary>
    /// Builds a virtual "ion-infinite-scroll-content" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonInfiniteScrollContent(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonInfiniteScrollContent>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-infinite-scroll-content", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-infinite-scroll-content" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonInfiniteScrollContent(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-infinite-scroll-content", children);
    }

    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerBubbles<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Const("loadingSpinner"), b.Const("bubbles"));
    }

    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerCircles<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Const("loadingSpinner"), b.Const("circles"));
    }

    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerCircular<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Const("loadingSpinner"), b.Const("circular"));
    }

    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerCrescent<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Const("loadingSpinner"), b.Const("crescent"));
    }

    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerDots<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Const("loadingSpinner"), b.Const("dots"));
    }

    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerLines<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Const("loadingSpinner"), b.Const("lines"));
    }

    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerLinesSmall<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Const("loadingSpinner"), b.Const("lines-small"));
    }

    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerLinesSharp<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Const("loadingSpinner"), b.Const("lines-sharp"));
    }

    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerLinesSharpSmall<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Const("loadingSpinner"), b.Const("lines-sharp-small"));
    }

    /// <summary>
    /// Optional text to display while loading. `loadingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `&lt;Ionic&gt;` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetLoadingText<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> loadingText) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Const("loadingText"), loadingText);
    }

    /// <summary>
    /// Optional text to display while loading. `loadingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `&lt;Ionic&gt;` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetLoadingText<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<IonicSafeString> loadingText) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Const("loadingText"), loadingText);
    }
}
public static partial class IonInfiniteScrollContentExtensions
{

    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerBubbles<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Const("loadingSpinner"), b.Const("bubbles"));
    }

    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerCircles<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Const("loadingSpinner"), b.Const("circles"));
    }

    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerCircular<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Const("loadingSpinner"), b.Const("circular"));
    }

    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerCrescent<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Const("loadingSpinner"), b.Const("crescent"));
    }

    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerDots<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Const("loadingSpinner"), b.Const("dots"));
    }

    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerLines<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Const("loadingSpinner"), b.Const("lines"));
    }

    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerLinesSmall<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Const("loadingSpinner"), b.Const("lines-small"));
    }

    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerLinesSharp<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Const("loadingSpinner"), b.Const("lines-sharp"));
    }

    /// <summary>
    /// An animated SVG spinner that shows while loading.
    /// </summary>
    public static void SetLoadingSpinnerLinesSharpSmall<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Const("loadingSpinner"), b.Const("lines-sharp-small"));
    }

    /// <summary>
    /// Optional text to display while loading. `loadingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `&lt;Ionic&gt;` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetLoadingText<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> loadingText) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Const("loadingText"), loadingText);
    }

    /// <summary>
    /// Optional text to display while loading. `loadingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `&lt;Ionic&gt;` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetLoadingText<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<IonicSafeString> loadingText) where T: IonInfiniteScrollContent
    {
        b.SetProperty(b.Const("loadingText"), loadingText);
    }
}