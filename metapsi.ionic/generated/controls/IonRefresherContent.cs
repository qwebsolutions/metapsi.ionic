using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonRefresherContent
{

    /// <summary>
    /// A static icon or a spinner to display when you begin to pull down. A spinner name can be provided to gradually show tick marks when pulling down on iOS devices.
    /// </summary>
    public string pullingIcon { get; set; }

    /// <summary>
    /// The text you want to display when you begin to pull down. `pullingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `&lt;Ionic&gt;` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public object pullingText { get; set; }

    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public string refreshingSpinner { get; set; }

    /// <summary>
    /// The text you want to display when performing a refresh. `refreshingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `&lt;Ionic&gt;` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public object refreshingText { get; set; }

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
    }
}
public static partial class IonRefresherContentControl
{
    /// <summary>
    /// Builds a "ion-refresher-content" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRefresherContent(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonRefresherContent>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-refresher-content", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-refresher-content" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRefresherContent(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-refresher-content", children);
    }

    /// <summary>
    /// Builds a "ion-refresher-content" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRefresherContent(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonRefresherContent>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-refresher-content", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-refresher-content" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRefresherContent(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-refresher-content", children);
    }

    /// <summary>
    /// A static icon or a spinner to display when you begin to pull down. A spinner name can be provided to gradually show tick marks when pulling down on iOS devices.
    /// </summary>
    public static void SetPullingIcon(this Metapsi.Html.AttributesBuilder<IonRefresherContent> b, string pullingIcon)
    {
        b.SetAttribute("pulling-icon", pullingIcon);
    }

    /// <summary>
    /// The text you want to display when you begin to pull down. `pullingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `&lt;Ionic&gt;` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetPullingText(this Metapsi.Html.AttributesBuilder<IonRefresherContent> b, string pullingText)
    {
        b.SetAttribute("pulling-text", pullingText);
    }

    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerBubbles(this Metapsi.Html.AttributesBuilder<IonRefresherContent> b)
    {
        b.SetAttribute("refreshing-spinner", "bubbles");
    }

    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerCircles(this Metapsi.Html.AttributesBuilder<IonRefresherContent> b)
    {
        b.SetAttribute("refreshing-spinner", "circles");
    }

    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerCircular(this Metapsi.Html.AttributesBuilder<IonRefresherContent> b)
    {
        b.SetAttribute("refreshing-spinner", "circular");
    }

    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerCrescent(this Metapsi.Html.AttributesBuilder<IonRefresherContent> b)
    {
        b.SetAttribute("refreshing-spinner", "crescent");
    }

    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerDots(this Metapsi.Html.AttributesBuilder<IonRefresherContent> b)
    {
        b.SetAttribute("refreshing-spinner", "dots");
    }

    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerLines(this Metapsi.Html.AttributesBuilder<IonRefresherContent> b)
    {
        b.SetAttribute("refreshing-spinner", "lines");
    }

    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerLinesSmall(this Metapsi.Html.AttributesBuilder<IonRefresherContent> b)
    {
        b.SetAttribute("refreshing-spinner", "lines-small");
    }

    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerLinesSharp(this Metapsi.Html.AttributesBuilder<IonRefresherContent> b)
    {
        b.SetAttribute("refreshing-spinner", "lines-sharp");
    }

    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerLinesSharpSmall(this Metapsi.Html.AttributesBuilder<IonRefresherContent> b)
    {
        b.SetAttribute("refreshing-spinner", "lines-sharp-small");
    }

    /// <summary>
    /// The text you want to display when performing a refresh. `refreshingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `&lt;Ionic&gt;` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetRefreshingText(this Metapsi.Html.AttributesBuilder<IonRefresherContent> b, string refreshingText)
    {
        b.SetAttribute("refreshing-text", refreshingText);
    }
    /// <summary>
    /// Builds a virtual "ion-refresher-content" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRefresherContent(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonRefresherContent>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-refresher-content", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-refresher-content" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRefresherContent(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-refresher-content", children);
    }

    /// <summary>
    /// Builds a virtual "ion-refresher-content" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRefresherContent(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonRefresherContent>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-refresher-content", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-refresher-content" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRefresherContent(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-refresher-content", children);
    }

    /// <summary>
    /// A static icon or a spinner to display when you begin to pull down. A spinner name can be provided to gradually show tick marks when pulling down on iOS devices.
    /// </summary>
    public static void SetPullingIcon<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> pullingIcon) where T: IonRefresherContent
    {
        b.SetProperty(b.Const("pullingIcon"), pullingIcon);
    }

    /// <summary>
    /// The text you want to display when you begin to pull down. `pullingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `&lt;Ionic&gt;` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetPullingText<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> pullingText) where T: IonRefresherContent
    {
        b.SetProperty(b.Const("pullingText"), pullingText);
    }

    /// <summary>
    /// The text you want to display when you begin to pull down. `pullingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `&lt;Ionic&gt;` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetPullingText<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<IonicSafeString> pullingText) where T: IonRefresherContent
    {
        b.SetProperty(b.Const("pullingText"), pullingText);
    }

    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerBubbles<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRefresherContent
    {
        b.SetProperty(b.Const("refreshingSpinner"), b.Const("bubbles"));
    }

    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerCircles<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRefresherContent
    {
        b.SetProperty(b.Const("refreshingSpinner"), b.Const("circles"));
    }

    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerCircular<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRefresherContent
    {
        b.SetProperty(b.Const("refreshingSpinner"), b.Const("circular"));
    }

    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerCrescent<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRefresherContent
    {
        b.SetProperty(b.Const("refreshingSpinner"), b.Const("crescent"));
    }

    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerDots<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRefresherContent
    {
        b.SetProperty(b.Const("refreshingSpinner"), b.Const("dots"));
    }

    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerLines<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRefresherContent
    {
        b.SetProperty(b.Const("refreshingSpinner"), b.Const("lines"));
    }

    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerLinesSmall<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRefresherContent
    {
        b.SetProperty(b.Const("refreshingSpinner"), b.Const("lines-small"));
    }

    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerLinesSharp<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRefresherContent
    {
        b.SetProperty(b.Const("refreshingSpinner"), b.Const("lines-sharp"));
    }

    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerLinesSharpSmall<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRefresherContent
    {
        b.SetProperty(b.Const("refreshingSpinner"), b.Const("lines-sharp-small"));
    }

    /// <summary>
    /// The text you want to display when performing a refresh. `refreshingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `&lt;Ionic&gt;` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetRefreshingText<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> refreshingText) where T: IonRefresherContent
    {
        b.SetProperty(b.Const("refreshingText"), refreshingText);
    }

    /// <summary>
    /// The text you want to display when performing a refresh. `refreshingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `&lt;Ionic&gt;` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetRefreshingText<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<IonicSafeString> refreshingText) where T: IonRefresherContent
    {
        b.SetProperty(b.Const("refreshingText"), refreshingText);
    }
}
public static partial class IonRefresherContentExtensions
{

    /// <summary>
    /// A static icon or a spinner to display when you begin to pull down. A spinner name can be provided to gradually show tick marks when pulling down on iOS devices.
    /// </summary>
    public static void SetPullingIcon<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> pullingIcon) where T: IonRefresherContent
    {
        b.SetProperty(b.Const("pullingIcon"), pullingIcon);
    }

    /// <summary>
    /// The text you want to display when you begin to pull down. `pullingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `&lt;Ionic&gt;` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetPullingText<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> pullingText) where T: IonRefresherContent
    {
        b.SetProperty(b.Const("pullingText"), pullingText);
    }

    /// <summary>
    /// The text you want to display when you begin to pull down. `pullingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `&lt;Ionic&gt;` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetPullingText<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<IonicSafeString> pullingText) where T: IonRefresherContent
    {
        b.SetProperty(b.Const("pullingText"), pullingText);
    }

    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerBubbles<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonRefresherContent
    {
        b.SetProperty(b.Const("refreshingSpinner"), b.Const("bubbles"));
    }

    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerCircles<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonRefresherContent
    {
        b.SetProperty(b.Const("refreshingSpinner"), b.Const("circles"));
    }

    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerCircular<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonRefresherContent
    {
        b.SetProperty(b.Const("refreshingSpinner"), b.Const("circular"));
    }

    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerCrescent<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonRefresherContent
    {
        b.SetProperty(b.Const("refreshingSpinner"), b.Const("crescent"));
    }

    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerDots<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonRefresherContent
    {
        b.SetProperty(b.Const("refreshingSpinner"), b.Const("dots"));
    }

    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerLines<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonRefresherContent
    {
        b.SetProperty(b.Const("refreshingSpinner"), b.Const("lines"));
    }

    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerLinesSmall<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonRefresherContent
    {
        b.SetProperty(b.Const("refreshingSpinner"), b.Const("lines-small"));
    }

    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerLinesSharp<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonRefresherContent
    {
        b.SetProperty(b.Const("refreshingSpinner"), b.Const("lines-sharp"));
    }

    /// <summary>
    /// An animated SVG spinner that shows when refreshing begins
    /// </summary>
    public static void SetRefreshingSpinnerLinesSharpSmall<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonRefresherContent
    {
        b.SetProperty(b.Const("refreshingSpinner"), b.Const("lines-sharp-small"));
    }

    /// <summary>
    /// The text you want to display when performing a refresh. `refreshingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `&lt;Ionic&gt;` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetRefreshingText<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> refreshingText) where T: IonRefresherContent
    {
        b.SetProperty(b.Const("refreshingText"), refreshingText);
    }

    /// <summary>
    /// The text you want to display when performing a refresh. `refreshingText` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `&lt;Ionic&gt;` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetRefreshingText<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<IonicSafeString> refreshingText) where T: IonRefresherContent
    {
        b.SetProperty(b.Const("refreshingText"), refreshingText);
    }
}