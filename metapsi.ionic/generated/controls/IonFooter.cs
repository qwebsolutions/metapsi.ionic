using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonFooter
{

    /// <summary>
    /// Describes the scroll effect that will be applied to the footer. Only applies in iOS mode.
    /// </summary>
    public string collapse { get; set; }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public string mode { get; set; }

    /// <summary>
    /// If `true`, the footer will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).  Note: In order to scroll content behind the footer, the `fullscreen` attribute needs to be set on the content.
    /// </summary>
    public bool translucent { get; set; }

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
    }
}
public static partial class IonFooterControl
{
    /// <summary>
    /// Builds a "ion-footer" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonFooter(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonFooter>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-footer", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-footer" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonFooter(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-footer", children);
    }

    /// <summary>
    /// Builds a "ion-footer" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonFooter(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonFooter>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-footer", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-footer" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonFooter(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-footer", children);
    }

    /// <summary>
    /// Describes the scroll effect that will be applied to the footer. Only applies in iOS mode.
    /// </summary>
    public static void SetCollapseFade(this Metapsi.Html.AttributesBuilder<IonFooter> b)
    {
        b.SetAttribute("collapse", "fade");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this Metapsi.Html.AttributesBuilder<IonFooter> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this Metapsi.Html.AttributesBuilder<IonFooter> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// If `true`, the footer will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).  Note: In order to scroll content behind the footer, the `fullscreen` attribute needs to be set on the content.
    /// </summary>
    public static void SetTranslucent(this Metapsi.Html.AttributesBuilder<IonFooter> b, bool translucent)
    {
        if (translucent) b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// If `true`, the footer will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).  Note: In order to scroll content behind the footer, the `fullscreen` attribute needs to be set on the content.
    /// </summary>
    public static void SetTranslucent(this Metapsi.Html.AttributesBuilder<IonFooter> b)
    {
        b.SetAttribute("translucent", "");
    }
    /// <summary>
    /// Builds a virtual "ion-footer" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonFooter(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonFooter>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-footer", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-footer" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonFooter(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-footer", children);
    }

    /// <summary>
    /// Builds a virtual "ion-footer" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonFooter(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonFooter>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-footer", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-footer" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonFooter(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-footer", children);
    }

    /// <summary>
    /// Describes the scroll effect that will be applied to the footer. Only applies in iOS mode.
    /// </summary>
    public static void SetCollapseFade<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFooter
    {
        b.SetProperty(b.Const("collapse"), b.Const("fade"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFooter
    {
        b.SetProperty(b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFooter
    {
        b.SetProperty(b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// If `true`, the footer will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).  Note: In order to scroll content behind the footer, the `fullscreen` attribute needs to be set on the content.
    /// </summary>
    public static void SetTranslucent<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFooter
    {
        b.SetProperty(b.Const("translucent"), b.Const(true));
    }
    public static void SetTranslucent<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> translucent) where T: IonFooter
    {
        b.SetProperty(b.Const("translucent"), translucent);
    }
}
public static partial class IonFooterExtensions
{

    /// <summary>
    /// Describes the scroll effect that will be applied to the footer. Only applies in iOS mode.
    /// </summary>
    public static void SetCollapseFade<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFooter
    {
        b.SetProperty(b.Const("collapse"), b.Const("fade"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFooter
    {
        b.SetProperty(b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFooter
    {
        b.SetProperty(b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// If `true`, the footer will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).  Note: In order to scroll content behind the footer, the `fullscreen` attribute needs to be set on the content.
    /// </summary>
    public static void SetTranslucent<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFooter
    {
        b.SetProperty(b.Const("translucent"), b.Const(true));
    }
    public static void SetTranslucent<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> translucent) where T: IonFooter
    {
        b.SetProperty(b.Const("translucent"), translucent);
    }
}