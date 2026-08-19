using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonFabButton
{

    /// <summary>
    /// If `true`, the fab button will be show a close icon.
    /// </summary>
    public bool activated { get; set; }

    /// <summary>
    /// The icon name to use for the close icon. This will appear when the fab button is pressed. Only applies if it is the main button inside of a fab containing a fab list.
    /// </summary>
    public string closeIcon { get; set; }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public string color { get; set; }

    /// <summary>
    /// If `true`, the user cannot interact with the fab button.
    /// </summary>
    public bool disabled { get; set; }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public string download { get; set; }

    /// <summary>
    /// The HTML form element or form element id. Used to submit a form when the button is not a child of the form.
    /// </summary>
    public object form { get; set; }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public string href { get; set; }

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
    /// If `true`, the fab button will show when in a fab-list.
    /// </summary>
    public bool show { get; set; }

    /// <summary>
    /// The size of the button. Set this to `small` in order to have a mini fab button.
    /// </summary>
    public string size { get; set; }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public string target { get; set; }

    /// <summary>
    /// If `true`, the fab button will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public bool translucent { get; set; }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public string type { get; set; }

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
    }
}
public static partial class IonFabButtonControl
{
    /// <summary>
    /// Builds a "ion-fab-button" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonFabButton(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonFabButton>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-fab-button", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-fab-button" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonFabButton(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-fab-button", children);
    }

    /// <summary>
    /// Builds a "ion-fab-button" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonFabButton(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonFabButton>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-fab-button", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-fab-button" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonFabButton(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-fab-button", children);
    }

    /// <summary>
    /// If `true`, the fab button will be show a close icon.
    /// </summary>
    public static void SetActivated(this Metapsi.Html.AttributesBuilder<IonFabButton> b, bool activated)
    {
        if (activated) b.SetAttribute("activated", "");
    }

    /// <summary>
    /// If `true`, the fab button will be show a close icon.
    /// </summary>
    public static void SetActivated(this Metapsi.Html.AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("activated", "");
    }

    /// <summary>
    /// The icon name to use for the close icon. This will appear when the fab button is pressed. Only applies if it is the main button inside of a fab containing a fab list.
    /// </summary>
    public static void SetCloseIcon(this Metapsi.Html.AttributesBuilder<IonFabButton> b, string closeIcon)
    {
        b.SetAttribute("close-icon", closeIcon);
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary(this Metapsi.Html.AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("color", "primary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary(this Metapsi.Html.AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("color", "secondary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary(this Metapsi.Html.AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("color", "tertiary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess(this Metapsi.Html.AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("color", "success");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning(this Metapsi.Html.AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("color", "warning");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger(this Metapsi.Html.AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("color", "danger");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight(this Metapsi.Html.AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("color", "light");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium(this Metapsi.Html.AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("color", "medium");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark(this Metapsi.Html.AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("color", "dark");
    }

    /// <summary>
    /// If `true`, the user cannot interact with the fab button.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonFabButton> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// If `true`, the user cannot interact with the fab button.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload(this Metapsi.Html.AttributesBuilder<IonFabButton> b, string download)
    {
        b.SetAttribute("download", download);
    }

    /// <summary>
    /// The HTML form element or form element id. Used to submit a form when the button is not a child of the form.
    /// </summary>
    public static void SetForm(this Metapsi.Html.AttributesBuilder<IonFabButton> b, string form)
    {
        b.SetAttribute("form", form);
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref(this Metapsi.Html.AttributesBuilder<IonFabButton> b, string href)
    {
        b.SetAttribute("href", href);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this Metapsi.Html.AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this Metapsi.Html.AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel(this Metapsi.Html.AttributesBuilder<IonFabButton> b, string rel)
    {
        b.SetAttribute("rel", rel);
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionForward(this Metapsi.Html.AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("router-direction", "forward");
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionBack(this Metapsi.Html.AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("router-direction", "back");
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionRoot(this Metapsi.Html.AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("router-direction", "root");
    }

    /// <summary>
    /// If `true`, the fab button will show when in a fab-list.
    /// </summary>
    public static void SetShow(this Metapsi.Html.AttributesBuilder<IonFabButton> b, bool show)
    {
        if (show) b.SetAttribute("show", "");
    }

    /// <summary>
    /// If `true`, the fab button will show when in a fab-list.
    /// </summary>
    public static void SetShow(this Metapsi.Html.AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("show", "");
    }

    /// <summary>
    /// The size of the button. Set this to `small` in order to have a mini fab button.
    /// </summary>
    public static void SetSizeSmall(this Metapsi.Html.AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("size", "small");
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget(this Metapsi.Html.AttributesBuilder<IonFabButton> b, string target)
    {
        b.SetAttribute("target", target);
    }

    /// <summary>
    /// If `true`, the fab button will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent(this Metapsi.Html.AttributesBuilder<IonFabButton> b, bool translucent)
    {
        if (translucent) b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// If `true`, the fab button will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent(this Metapsi.Html.AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeSubmit(this Metapsi.Html.AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("type", "submit");
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeReset(this Metapsi.Html.AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("type", "reset");
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeButton(this Metapsi.Html.AttributesBuilder<IonFabButton> b)
    {
        b.SetAttribute("type", "button");
    }
    /// <summary>
    /// Builds a virtual "ion-fab-button" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonFabButton(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonFabButton>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-fab-button", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-fab-button" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonFabButton(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-fab-button", children);
    }

    /// <summary>
    /// Builds a virtual "ion-fab-button" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonFabButton(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonFabButton>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-fab-button", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-fab-button" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonFabButton(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-fab-button", children);
    }

    /// <summary>
    /// If `true`, the fab button will be show a close icon.
    /// </summary>
    public static void SetActivated<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("activated"), b.Const(true));
    }
    public static void SetActivated<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> activated) where T: IonFabButton
    {
        b.SetProperty(b.Const("activated"), activated);
    }

    /// <summary>
    /// The icon name to use for the close icon. This will appear when the fab button is pressed. Only applies if it is the main button inside of a fab containing a fab list.
    /// </summary>
    public static void SetCloseIcon<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> closeIcon) where T: IonFabButton
    {
        b.SetProperty(b.Const("closeIcon"), closeIcon);
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("color"), b.Const("primary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("color"), b.Const("secondary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("color"), b.Const("tertiary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("color"), b.Const("success"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("color"), b.Const("warning"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("color"), b.Const("danger"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("color"), b.Const("light"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("color"), b.Const("medium"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("color"), b.Const("dark"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> color) where T: IonFabButton
    {
        b.SetProperty(b.Const("color"), color);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the fab button.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("disabled"), b.Const(true));
    }
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonFabButton
    {
        b.SetProperty(b.Const("disabled"), disabled);
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> download) where T: IonFabButton
    {
        b.SetProperty(b.Const("download"), download);
    }

    /// <summary>
    /// The HTML form element or form element id. Used to submit a form when the button is not a child of the form.
    /// </summary>
    public static void SetForm<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> form) where T: IonFabButton
    {
        b.SetProperty(b.Const("form"), form);
    }

    /// <summary>
    /// The HTML form element or form element id. Used to submit a form when the button is not a child of the form.
    /// </summary>
    public static void SetForm<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<HTMLFormElement> form) where T: IonFabButton
    {
        b.SetProperty(b.Const("form"), form);
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> href) where T: IonFabButton
    {
        b.SetProperty(b.Const("href"), href);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> rel) where T: IonFabButton
    {
        b.SetProperty(b.Const("rel"), rel);
    }

    /// <summary>
    /// When using a router, it specifies the transition animation when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterAnimation<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, Animation>> routerAnimation) where T: IonFabButton
    {
        b.SetProperty(b.Const("routerAnimation"), routerAnimation);
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionForward<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("routerDirection"), b.Const("forward"));
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionBack<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("routerDirection"), b.Const("back"));
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionRoot<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("routerDirection"), b.Const("root"));
    }

    /// <summary>
    /// If `true`, the fab button will show when in a fab-list.
    /// </summary>
    public static void SetShow<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("show"), b.Const(true));
    }
    public static void SetShow<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> show) where T: IonFabButton
    {
        b.SetProperty(b.Const("show"), show);
    }

    /// <summary>
    /// The size of the button. Set this to `small` in order to have a mini fab button.
    /// </summary>
    public static void SetSizeSmall<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("size"), b.Const("small"));
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> target) where T: IonFabButton
    {
        b.SetProperty(b.Const("target"), target);
    }

    /// <summary>
    /// If `true`, the fab button will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("translucent"), b.Const(true));
    }
    public static void SetTranslucent<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> translucent) where T: IonFabButton
    {
        b.SetProperty(b.Const("translucent"), translucent);
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeSubmit<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("type"), b.Const("submit"));
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeReset<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("type"), b.Const("reset"));
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeButton<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("type"), b.Const("button"));
    }

    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    public static void OnIonBlur<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonFabButton
    {
        b.SetProperty(b.Const("onionBlur"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    [System.Obsolete]
    public static void OnIonBlur<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonFabButton
    {
        b.OnIonBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    public static void OnIonBlur<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonFabButton
    {
        b.SetProperty(b.Const("onionBlur"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    [System.Obsolete]
    public static void OnIonBlur<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonFabButton
    {
        b.OnIonBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the button has focus.
    /// </summary>
    public static void OnIonFocus<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonFabButton
    {
        b.SetProperty(b.Const("onionFocus"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the button has focus.
    /// </summary>
    [System.Obsolete]
    public static void OnIonFocus<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonFabButton
    {
        b.OnIonFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the button has focus.
    /// </summary>
    public static void OnIonFocus<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonFabButton
    {
        b.SetProperty(b.Const("onionFocus"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the button has focus.
    /// </summary>
    [System.Obsolete]
    public static void OnIonFocus<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonFabButton
    {
        b.OnIonFocus(b.MakeAction(action));
    }
}
public static partial class IonFabButtonExtensions
{

    /// <summary>
    /// If `true`, the fab button will be show a close icon.
    /// </summary>
    public static void SetActivated<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("activated"), b.Const(true));
    }
    public static void SetActivated<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> activated) where T: IonFabButton
    {
        b.SetProperty(b.Const("activated"), activated);
    }

    /// <summary>
    /// The icon name to use for the close icon. This will appear when the fab button is pressed. Only applies if it is the main button inside of a fab containing a fab list.
    /// </summary>
    public static void SetCloseIcon<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> closeIcon) where T: IonFabButton
    {
        b.SetProperty(b.Const("closeIcon"), closeIcon);
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("color"), b.Const("primary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("color"), b.Const("secondary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("color"), b.Const("tertiary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("color"), b.Const("success"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("color"), b.Const("warning"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("color"), b.Const("danger"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("color"), b.Const("light"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("color"), b.Const("medium"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("color"), b.Const("dark"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> color) where T: IonFabButton
    {
        b.SetProperty(b.Const("color"), color);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the fab button.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("disabled"), b.Const(true));
    }
    public static void SetDisabled<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonFabButton
    {
        b.SetProperty(b.Const("disabled"), disabled);
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> download) where T: IonFabButton
    {
        b.SetProperty(b.Const("download"), download);
    }

    /// <summary>
    /// The HTML form element or form element id. Used to submit a form when the button is not a child of the form.
    /// </summary>
    public static void SetForm<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> form) where T: IonFabButton
    {
        b.SetProperty(b.Const("form"), form);
    }

    /// <summary>
    /// The HTML form element or form element id. Used to submit a form when the button is not a child of the form.
    /// </summary>
    public static void SetForm<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<HTMLFormElement> form) where T: IonFabButton
    {
        b.SetProperty(b.Const("form"), form);
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> href) where T: IonFabButton
    {
        b.SetProperty(b.Const("href"), href);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> rel) where T: IonFabButton
    {
        b.SetProperty(b.Const("rel"), rel);
    }

    /// <summary>
    /// When using a router, it specifies the transition animation when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterAnimation<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, Animation>> routerAnimation) where T: IonFabButton
    {
        b.SetProperty(b.Const("routerAnimation"), routerAnimation);
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionForward<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("routerDirection"), b.Const("forward"));
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionBack<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("routerDirection"), b.Const("back"));
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionRoot<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("routerDirection"), b.Const("root"));
    }

    /// <summary>
    /// If `true`, the fab button will show when in a fab-list.
    /// </summary>
    public static void SetShow<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("show"), b.Const(true));
    }
    public static void SetShow<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> show) where T: IonFabButton
    {
        b.SetProperty(b.Const("show"), show);
    }

    /// <summary>
    /// The size of the button. Set this to `small` in order to have a mini fab button.
    /// </summary>
    public static void SetSizeSmall<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("size"), b.Const("small"));
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> target) where T: IonFabButton
    {
        b.SetProperty(b.Const("target"), target);
    }

    /// <summary>
    /// If `true`, the fab button will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("translucent"), b.Const(true));
    }
    public static void SetTranslucent<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> translucent) where T: IonFabButton
    {
        b.SetProperty(b.Const("translucent"), translucent);
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeSubmit<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("type"), b.Const("submit"));
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeReset<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("type"), b.Const("reset"));
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeButton<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonFabButton
    {
        b.SetProperty(b.Const("type"), b.Const("button"));
    }
}