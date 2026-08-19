using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonItem
{

    /// <summary>
    /// If `true`, a button tag will be rendered and the item will be tappable.
    /// </summary>
    public bool button { get; set; }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public string color { get; set; }

    /// <summary>
    /// If `true`, a detail arrow will appear on the item. Defaults to `false` unless the `mode` is `ios` and an `href` or `button` property is present.
    /// </summary>
    public bool detail { get; set; }

    /// <summary>
    /// The icon to use when `detail` is set to `true`.
    /// </summary>
    public string detailIcon { get; set; }

    /// <summary>
    /// If `true`, the user cannot interact with the item.
    /// </summary>
    public bool disabled { get; set; }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public string download { get; set; }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public string href { get; set; }

    /// <summary>
    /// How the bottom border should be displayed on the item.
    /// </summary>
    public string lines { get; set; }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public string mode { get; set; }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public string rel { get; set; }

    /// <summary>
    /// When using a router, it specifies the transition animation when navigating to another page using `href`.
    /// </summary>
    public System.Func<object, object, Animation> routerAnimation { get; set; }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public string routerDirection { get; set; }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public string target { get; set; }

    /// <summary>
    /// The type of the button. Only used when an `onclick` or `button` property is present.
    /// </summary>
    public string type { get; set; }

    public static partial class Slot
    {
        /// <summary>
        /// Content is placed to the right of the item text in LTR, and to the left in RTL.
        /// </summary>
        public const string End = "end";
        /// <summary>
        /// Content is placed to the left of the item text in LTR, and to the right in RTL.
        /// </summary>
        public const string Start = "start";
    }
    [System.Obsolete]
    public static partial class Method
    {
    }
}
public static partial class IonItemControl
{
    /// <summary>
    /// Builds a "ion-item" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonItem(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonItem>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-item", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-item" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonItem(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-item", children);
    }

    /// <summary>
    /// Builds a "ion-item" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonItem(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonItem>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-item", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-item" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonItem(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-item", children);
    }

    /// <summary>
    /// If `true`, a button tag will be rendered and the item will be tappable.
    /// </summary>
    public static void SetButton(this Metapsi.Html.AttributesBuilder<IonItem> b, bool button)
    {
        if (button) b.SetAttribute("button", "");
    }

    /// <summary>
    /// If `true`, a button tag will be rendered and the item will be tappable.
    /// </summary>
    public static void SetButton(this Metapsi.Html.AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("button", "");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary(this Metapsi.Html.AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("color", "primary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary(this Metapsi.Html.AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("color", "secondary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary(this Metapsi.Html.AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("color", "tertiary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess(this Metapsi.Html.AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("color", "success");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning(this Metapsi.Html.AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("color", "warning");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger(this Metapsi.Html.AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("color", "danger");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight(this Metapsi.Html.AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("color", "light");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium(this Metapsi.Html.AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("color", "medium");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark(this Metapsi.Html.AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("color", "dark");
    }

    /// <summary>
    /// If `true`, a detail arrow will appear on the item. Defaults to `false` unless the `mode` is `ios` and an `href` or `button` property is present.
    /// </summary>
    public static void SetDetail(this Metapsi.Html.AttributesBuilder<IonItem> b, bool detail)
    {
        if (detail) b.SetAttribute("detail", "");
    }

    /// <summary>
    /// If `true`, a detail arrow will appear on the item. Defaults to `false` unless the `mode` is `ios` and an `href` or `button` property is present.
    /// </summary>
    public static void SetDetail(this Metapsi.Html.AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("detail", "");
    }

    /// <summary>
    /// The icon to use when `detail` is set to `true`.
    /// </summary>
    public static void SetDetailIcon(this Metapsi.Html.AttributesBuilder<IonItem> b, string detailIcon)
    {
        b.SetAttribute("detail-icon", detailIcon);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the item.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonItem> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// If `true`, the user cannot interact with the item.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload(this Metapsi.Html.AttributesBuilder<IonItem> b, string download)
    {
        b.SetAttribute("download", download);
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref(this Metapsi.Html.AttributesBuilder<IonItem> b, string href)
    {
        b.SetAttribute("href", href);
    }

    /// <summary>
    /// How the bottom border should be displayed on the item.
    /// </summary>
    public static void SetLinesInset(this Metapsi.Html.AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("lines", "inset");
    }

    /// <summary>
    /// How the bottom border should be displayed on the item.
    /// </summary>
    public static void SetLinesFull(this Metapsi.Html.AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("lines", "full");
    }

    /// <summary>
    /// How the bottom border should be displayed on the item.
    /// </summary>
    public static void SetLinesNone(this Metapsi.Html.AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("lines", "none");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this Metapsi.Html.AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this Metapsi.Html.AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel(this Metapsi.Html.AttributesBuilder<IonItem> b, string rel)
    {
        b.SetAttribute("rel", rel);
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionForward(this Metapsi.Html.AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("router-direction", "forward");
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionBack(this Metapsi.Html.AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("router-direction", "back");
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionRoot(this Metapsi.Html.AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("router-direction", "root");
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget(this Metapsi.Html.AttributesBuilder<IonItem> b, string target)
    {
        b.SetAttribute("target", target);
    }

    /// <summary>
    /// The type of the button. Only used when an `onclick` or `button` property is present.
    /// </summary>
    public static void SetTypeSubmit(this Metapsi.Html.AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("type", "submit");
    }

    /// <summary>
    /// The type of the button. Only used when an `onclick` or `button` property is present.
    /// </summary>
    public static void SetTypeReset(this Metapsi.Html.AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("type", "reset");
    }

    /// <summary>
    /// The type of the button. Only used when an `onclick` or `button` property is present.
    /// </summary>
    public static void SetTypeButton(this Metapsi.Html.AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("type", "button");
    }
    /// <summary>
    /// Builds a virtual "ion-item" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonItem(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonItem>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-item", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-item" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonItem(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-item", children);
    }

    /// <summary>
    /// Builds a virtual "ion-item" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonItem(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonItem>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-item", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-item" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonItem(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-item", children);
    }

    /// <summary>
    /// If `true`, a button tag will be rendered and the item will be tappable.
    /// </summary>
    public static void SetButton<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("button"), b.Const(true));
    }
    public static void SetButton<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> button) where T: IonItem
    {
        b.SetProperty(b.Const("button"), button);
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("color"), b.Const("primary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("color"), b.Const("secondary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("color"), b.Const("tertiary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("color"), b.Const("success"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("color"), b.Const("warning"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("color"), b.Const("danger"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("color"), b.Const("light"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("color"), b.Const("medium"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("color"), b.Const("dark"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> color) where T: IonItem
    {
        b.SetProperty(b.Const("color"), color);
    }

    /// <summary>
    /// If `true`, a detail arrow will appear on the item. Defaults to `false` unless the `mode` is `ios` and an `href` or `button` property is present.
    /// </summary>
    public static void SetDetail<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("detail"), b.Const(true));
    }
    public static void SetDetail<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> detail) where T: IonItem
    {
        b.SetProperty(b.Const("detail"), detail);
    }

    /// <summary>
    /// The icon to use when `detail` is set to `true`.
    /// </summary>
    public static void SetDetailIcon<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> detailIcon) where T: IonItem
    {
        b.SetProperty(b.Const("detailIcon"), detailIcon);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the item.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("disabled"), b.Const(true));
    }
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonItem
    {
        b.SetProperty(b.Const("disabled"), disabled);
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> download) where T: IonItem
    {
        b.SetProperty(b.Const("download"), download);
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> href) where T: IonItem
    {
        b.SetProperty(b.Const("href"), href);
    }

    /// <summary>
    /// How the bottom border should be displayed on the item.
    /// </summary>
    public static void SetLinesInset<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("lines"), b.Const("inset"));
    }

    /// <summary>
    /// How the bottom border should be displayed on the item.
    /// </summary>
    public static void SetLinesFull<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("lines"), b.Const("full"));
    }

    /// <summary>
    /// How the bottom border should be displayed on the item.
    /// </summary>
    public static void SetLinesNone<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("lines"), b.Const("none"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> rel) where T: IonItem
    {
        b.SetProperty(b.Const("rel"), rel);
    }

    /// <summary>
    /// When using a router, it specifies the transition animation when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterAnimation<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, Animation>> routerAnimation) where T: IonItem
    {
        b.SetProperty(b.Const("routerAnimation"), routerAnimation);
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionForward<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("routerDirection"), b.Const("forward"));
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionBack<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("routerDirection"), b.Const("back"));
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionRoot<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("routerDirection"), b.Const("root"));
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> target) where T: IonItem
    {
        b.SetProperty(b.Const("target"), target);
    }

    /// <summary>
    /// The type of the button. Only used when an `onclick` or `button` property is present.
    /// </summary>
    public static void SetTypeSubmit<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("type"), b.Const("submit"));
    }

    /// <summary>
    /// The type of the button. Only used when an `onclick` or `button` property is present.
    /// </summary>
    public static void SetTypeReset<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("type"), b.Const("reset"));
    }

    /// <summary>
    /// The type of the button. Only used when an `onclick` or `button` property is present.
    /// </summary>
    public static void SetTypeButton<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("type"), b.Const("button"));
    }
}
public static partial class IonItemExtensions
{

    /// <summary>
    /// If `true`, a button tag will be rendered and the item will be tappable.
    /// </summary>
    public static void SetButton<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("button"), b.Const(true));
    }
    public static void SetButton<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> button) where T: IonItem
    {
        b.SetProperty(b.Const("button"), button);
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("color"), b.Const("primary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("color"), b.Const("secondary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("color"), b.Const("tertiary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("color"), b.Const("success"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("color"), b.Const("warning"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("color"), b.Const("danger"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("color"), b.Const("light"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("color"), b.Const("medium"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("color"), b.Const("dark"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> color) where T: IonItem
    {
        b.SetProperty(b.Const("color"), color);
    }

    /// <summary>
    /// If `true`, a detail arrow will appear on the item. Defaults to `false` unless the `mode` is `ios` and an `href` or `button` property is present.
    /// </summary>
    public static void SetDetail<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("detail"), b.Const(true));
    }
    public static void SetDetail<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> detail) where T: IonItem
    {
        b.SetProperty(b.Const("detail"), detail);
    }

    /// <summary>
    /// The icon to use when `detail` is set to `true`.
    /// </summary>
    public static void SetDetailIcon<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> detailIcon) where T: IonItem
    {
        b.SetProperty(b.Const("detailIcon"), detailIcon);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the item.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("disabled"), b.Const(true));
    }
    public static void SetDisabled<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonItem
    {
        b.SetProperty(b.Const("disabled"), disabled);
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> download) where T: IonItem
    {
        b.SetProperty(b.Const("download"), download);
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> href) where T: IonItem
    {
        b.SetProperty(b.Const("href"), href);
    }

    /// <summary>
    /// How the bottom border should be displayed on the item.
    /// </summary>
    public static void SetLinesInset<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("lines"), b.Const("inset"));
    }

    /// <summary>
    /// How the bottom border should be displayed on the item.
    /// </summary>
    public static void SetLinesFull<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("lines"), b.Const("full"));
    }

    /// <summary>
    /// How the bottom border should be displayed on the item.
    /// </summary>
    public static void SetLinesNone<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("lines"), b.Const("none"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> rel) where T: IonItem
    {
        b.SetProperty(b.Const("rel"), rel);
    }

    /// <summary>
    /// When using a router, it specifies the transition animation when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterAnimation<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, Animation>> routerAnimation) where T: IonItem
    {
        b.SetProperty(b.Const("routerAnimation"), routerAnimation);
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionForward<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("routerDirection"), b.Const("forward"));
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionBack<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("routerDirection"), b.Const("back"));
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionRoot<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("routerDirection"), b.Const("root"));
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> target) where T: IonItem
    {
        b.SetProperty(b.Const("target"), target);
    }

    /// <summary>
    /// The type of the button. Only used when an `onclick` or `button` property is present.
    /// </summary>
    public static void SetTypeSubmit<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("type"), b.Const("submit"));
    }

    /// <summary>
    /// The type of the button. Only used when an `onclick` or `button` property is present.
    /// </summary>
    public static void SetTypeReset<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("type"), b.Const("reset"));
    }

    /// <summary>
    /// The type of the button. Only used when an `onclick` or `button` property is present.
    /// </summary>
    public static void SetTypeButton<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonItem
    {
        b.SetProperty(b.Const("type"), b.Const("button"));
    }
}