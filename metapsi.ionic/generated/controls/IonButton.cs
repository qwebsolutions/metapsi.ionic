using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonButton
{

    /// <summary>
    /// The type of button.
    /// </summary>
    public string buttonType { get; set; }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public string color { get; set; }

    /// <summary>
    /// If `true`, the user cannot interact with the button.
    /// </summary>
    public bool disabled { get; set; }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public string download { get; set; }

    /// <summary>
    /// Set to `"block"` for a full-width button or to `"full"` for a full-width button with square corners and no left or right borders.
    /// </summary>
    public string expand { get; set; }

    /// <summary>
    /// Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`.
    /// </summary>
    public string fill { get; set; }

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
    /// Set to `"round"` for a button with more rounded corners.
    /// </summary>
    public string shape { get; set; }

    /// <summary>
    /// Set to `"small"` for a button with less height and padding, to `"default"` for a button with the default height and padding, or to `"large"` for a button with more height and padding. By default the size is unset, unless the button is inside of an item, where the size is `"small"` by default. Set the size to `"default"` inside of an item to make it a standard size button.
    /// </summary>
    public string size { get; set; }

    /// <summary>
    /// If `true`, activates a button with a heavier font weight.
    /// </summary>
    public bool strong { get; set; }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public string target { get; set; }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public string type { get; set; }

    public static partial class Slot
    {
        /// <summary>
        /// Content is placed to the right of the button text in LTR, and to the left in RTL.
        /// </summary>
        public const string End = "end";
        /// <summary>
        /// Should be used on an icon in a button that has no text.
        /// </summary>
        public const string IconOnly = "icon-only";
        /// <summary>
        /// Content is placed to the left of the button text in LTR, and to the right in RTL.
        /// </summary>
        public const string Start = "start";
    }
    [System.Obsolete]
    public static partial class Method
    {
    }
}
public static partial class IonButtonControl
{
    /// <summary>
    /// Builds a "ion-button" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonButton(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonButton>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-button", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-button" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonButton(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-button", children);
    }

    /// <summary>
    /// Builds a "ion-button" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonButton(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonButton>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-button", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-button" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonButton(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-button", children);
    }

    /// <summary>
    /// The type of button.
    /// </summary>
    public static void SetButtonType(this Metapsi.Html.AttributesBuilder<IonButton> b, string buttonType)
    {
        b.SetAttribute("button-type", buttonType);
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary(this Metapsi.Html.AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("color", "primary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary(this Metapsi.Html.AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("color", "secondary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary(this Metapsi.Html.AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("color", "tertiary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess(this Metapsi.Html.AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("color", "success");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning(this Metapsi.Html.AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("color", "warning");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger(this Metapsi.Html.AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("color", "danger");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight(this Metapsi.Html.AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("color", "light");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium(this Metapsi.Html.AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("color", "medium");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark(this Metapsi.Html.AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("color", "dark");
    }

    /// <summary>
    /// If `true`, the user cannot interact with the button.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonButton> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// If `true`, the user cannot interact with the button.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload(this Metapsi.Html.AttributesBuilder<IonButton> b, string download)
    {
        b.SetAttribute("download", download);
    }

    /// <summary>
    /// Set to `"block"` for a full-width button or to `"full"` for a full-width button with square corners and no left or right borders.
    /// </summary>
    public static void SetExpandFull(this Metapsi.Html.AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("expand", "full");
    }

    /// <summary>
    /// Set to `"block"` for a full-width button or to `"full"` for a full-width button with square corners and no left or right borders.
    /// </summary>
    public static void SetExpandBlock(this Metapsi.Html.AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("expand", "block");
    }

    /// <summary>
    /// Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`.
    /// </summary>
    public static void SetFillClear(this Metapsi.Html.AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("fill", "clear");
    }

    /// <summary>
    /// Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`.
    /// </summary>
    public static void SetFillOutline(this Metapsi.Html.AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("fill", "outline");
    }

    /// <summary>
    /// Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`.
    /// </summary>
    public static void SetFillSolid(this Metapsi.Html.AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("fill", "solid");
    }

    /// <summary>
    /// Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`.
    /// </summary>
    public static void SetFillDefault(this Metapsi.Html.AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("fill", "default");
    }

    /// <summary>
    /// The HTML form element or form element id. Used to submit a form when the button is not a child of the form.
    /// </summary>
    public static void SetForm(this Metapsi.Html.AttributesBuilder<IonButton> b, string form)
    {
        b.SetAttribute("form", form);
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref(this Metapsi.Html.AttributesBuilder<IonButton> b, string href)
    {
        b.SetAttribute("href", href);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this Metapsi.Html.AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this Metapsi.Html.AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel(this Metapsi.Html.AttributesBuilder<IonButton> b, string rel)
    {
        b.SetAttribute("rel", rel);
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionForward(this Metapsi.Html.AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("router-direction", "forward");
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionBack(this Metapsi.Html.AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("router-direction", "back");
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionRoot(this Metapsi.Html.AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("router-direction", "root");
    }

    /// <summary>
    /// Set to `"round"` for a button with more rounded corners.
    /// </summary>
    public static void SetShapeRound(this Metapsi.Html.AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("shape", "round");
    }

    /// <summary>
    /// Set to `"small"` for a button with less height and padding, to `"default"` for a button with the default height and padding, or to `"large"` for a button with more height and padding. By default the size is unset, unless the button is inside of an item, where the size is `"small"` by default. Set the size to `"default"` inside of an item to make it a standard size button.
    /// </summary>
    public static void SetSizeDefault(this Metapsi.Html.AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("size", "default");
    }

    /// <summary>
    /// Set to `"small"` for a button with less height and padding, to `"default"` for a button with the default height and padding, or to `"large"` for a button with more height and padding. By default the size is unset, unless the button is inside of an item, where the size is `"small"` by default. Set the size to `"default"` inside of an item to make it a standard size button.
    /// </summary>
    public static void SetSizeSmall(this Metapsi.Html.AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("size", "small");
    }

    /// <summary>
    /// Set to `"small"` for a button with less height and padding, to `"default"` for a button with the default height and padding, or to `"large"` for a button with more height and padding. By default the size is unset, unless the button is inside of an item, where the size is `"small"` by default. Set the size to `"default"` inside of an item to make it a standard size button.
    /// </summary>
    public static void SetSizeLarge(this Metapsi.Html.AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("size", "large");
    }

    /// <summary>
    /// If `true`, activates a button with a heavier font weight.
    /// </summary>
    public static void SetStrong(this Metapsi.Html.AttributesBuilder<IonButton> b, bool strong)
    {
        if (strong) b.SetAttribute("strong", "");
    }

    /// <summary>
    /// If `true`, activates a button with a heavier font weight.
    /// </summary>
    public static void SetStrong(this Metapsi.Html.AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("strong", "");
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget(this Metapsi.Html.AttributesBuilder<IonButton> b, string target)
    {
        b.SetAttribute("target", target);
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeSubmit(this Metapsi.Html.AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("type", "submit");
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeReset(this Metapsi.Html.AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("type", "reset");
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeButton(this Metapsi.Html.AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("type", "button");
    }
    /// <summary>
    /// Builds a virtual "ion-button" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonButton(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonButton>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-button", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-button" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonButton(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-button", children);
    }

    /// <summary>
    /// Builds a virtual "ion-button" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonButton(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonButton>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-button", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-button" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonButton(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-button", children);
    }

    /// <summary>
    /// The type of button.
    /// </summary>
    public static void SetButtonType<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> buttonType) where T: IonButton
    {
        b.SetProperty(b.Const("buttonType"), buttonType);
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("color"), b.Const("primary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("color"), b.Const("secondary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("color"), b.Const("tertiary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("color"), b.Const("success"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("color"), b.Const("warning"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("color"), b.Const("danger"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("color"), b.Const("light"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("color"), b.Const("medium"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("color"), b.Const("dark"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> color) where T: IonButton
    {
        b.SetProperty(b.Const("color"), color);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the button.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("disabled"), b.Const(true));
    }
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonButton
    {
        b.SetProperty(b.Const("disabled"), disabled);
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> download) where T: IonButton
    {
        b.SetProperty(b.Const("download"), download);
    }

    /// <summary>
    /// Set to `"block"` for a full-width button or to `"full"` for a full-width button with square corners and no left or right borders.
    /// </summary>
    public static void SetExpandFull<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("expand"), b.Const("full"));
    }

    /// <summary>
    /// Set to `"block"` for a full-width button or to `"full"` for a full-width button with square corners and no left or right borders.
    /// </summary>
    public static void SetExpandBlock<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("expand"), b.Const("block"));
    }

    /// <summary>
    /// Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`.
    /// </summary>
    public static void SetFillClear<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("fill"), b.Const("clear"));
    }

    /// <summary>
    /// Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`.
    /// </summary>
    public static void SetFillOutline<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("fill"), b.Const("outline"));
    }

    /// <summary>
    /// Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`.
    /// </summary>
    public static void SetFillSolid<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("fill"), b.Const("solid"));
    }

    /// <summary>
    /// Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`.
    /// </summary>
    public static void SetFillDefault<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("fill"), b.Const("default"));
    }

    /// <summary>
    /// The HTML form element or form element id. Used to submit a form when the button is not a child of the form.
    /// </summary>
    public static void SetForm<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> form) where T: IonButton
    {
        b.SetProperty(b.Const("form"), form);
    }

    /// <summary>
    /// The HTML form element or form element id. Used to submit a form when the button is not a child of the form.
    /// </summary>
    public static void SetForm<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<HTMLFormElement> form) where T: IonButton
    {
        b.SetProperty(b.Const("form"), form);
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> href) where T: IonButton
    {
        b.SetProperty(b.Const("href"), href);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> rel) where T: IonButton
    {
        b.SetProperty(b.Const("rel"), rel);
    }

    /// <summary>
    /// When using a router, it specifies the transition animation when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterAnimation<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, Animation>> routerAnimation) where T: IonButton
    {
        b.SetProperty(b.Const("routerAnimation"), routerAnimation);
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionForward<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("routerDirection"), b.Const("forward"));
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionBack<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("routerDirection"), b.Const("back"));
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionRoot<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("routerDirection"), b.Const("root"));
    }

    /// <summary>
    /// Set to `"round"` for a button with more rounded corners.
    /// </summary>
    public static void SetShapeRound<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("shape"), b.Const("round"));
    }

    /// <summary>
    /// Set to `"small"` for a button with less height and padding, to `"default"` for a button with the default height and padding, or to `"large"` for a button with more height and padding. By default the size is unset, unless the button is inside of an item, where the size is `"small"` by default. Set the size to `"default"` inside of an item to make it a standard size button.
    /// </summary>
    public static void SetSizeDefault<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("size"), b.Const("default"));
    }

    /// <summary>
    /// Set to `"small"` for a button with less height and padding, to `"default"` for a button with the default height and padding, or to `"large"` for a button with more height and padding. By default the size is unset, unless the button is inside of an item, where the size is `"small"` by default. Set the size to `"default"` inside of an item to make it a standard size button.
    /// </summary>
    public static void SetSizeSmall<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("size"), b.Const("small"));
    }

    /// <summary>
    /// Set to `"small"` for a button with less height and padding, to `"default"` for a button with the default height and padding, or to `"large"` for a button with more height and padding. By default the size is unset, unless the button is inside of an item, where the size is `"small"` by default. Set the size to `"default"` inside of an item to make it a standard size button.
    /// </summary>
    public static void SetSizeLarge<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("size"), b.Const("large"));
    }

    /// <summary>
    /// If `true`, activates a button with a heavier font weight.
    /// </summary>
    public static void SetStrong<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("strong"), b.Const(true));
    }
    public static void SetStrong<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> strong) where T: IonButton
    {
        b.SetProperty(b.Const("strong"), strong);
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> target) where T: IonButton
    {
        b.SetProperty(b.Const("target"), target);
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeSubmit<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("type"), b.Const("submit"));
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeReset<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("type"), b.Const("reset"));
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeButton<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("type"), b.Const("button"));
    }

    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    public static void OnIonBlur<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonButton
    {
        b.SetProperty(b.Const("onionBlur"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    [System.Obsolete]
    public static void OnIonBlur<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonButton
    {
        b.OnIonBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    public static void OnIonBlur<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonButton
    {
        b.SetProperty(b.Const("onionBlur"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    [System.Obsolete]
    public static void OnIonBlur<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonButton
    {
        b.OnIonBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the button has focus.
    /// </summary>
    public static void OnIonFocus<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonButton
    {
        b.SetProperty(b.Const("onionFocus"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the button has focus.
    /// </summary>
    [System.Obsolete]
    public static void OnIonFocus<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonButton
    {
        b.OnIonFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the button has focus.
    /// </summary>
    public static void OnIonFocus<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonButton
    {
        b.SetProperty(b.Const("onionFocus"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the button has focus.
    /// </summary>
    [System.Obsolete]
    public static void OnIonFocus<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonButton
    {
        b.OnIonFocus(b.MakeAction(action));
    }
}
public static partial class IonButtonExtensions
{

    /// <summary>
    /// The type of button.
    /// </summary>
    public static void SetButtonType<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> buttonType) where T: IonButton
    {
        b.SetProperty(b.Const("buttonType"), buttonType);
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("color"), b.Const("primary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("color"), b.Const("secondary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("color"), b.Const("tertiary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("color"), b.Const("success"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("color"), b.Const("warning"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("color"), b.Const("danger"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("color"), b.Const("light"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("color"), b.Const("medium"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("color"), b.Const("dark"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> color) where T: IonButton
    {
        b.SetProperty(b.Const("color"), color);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the button.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("disabled"), b.Const(true));
    }
    public static void SetDisabled<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonButton
    {
        b.SetProperty(b.Const("disabled"), disabled);
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> download) where T: IonButton
    {
        b.SetProperty(b.Const("download"), download);
    }

    /// <summary>
    /// Set to `"block"` for a full-width button or to `"full"` for a full-width button with square corners and no left or right borders.
    /// </summary>
    public static void SetExpandFull<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("expand"), b.Const("full"));
    }

    /// <summary>
    /// Set to `"block"` for a full-width button or to `"full"` for a full-width button with square corners and no left or right borders.
    /// </summary>
    public static void SetExpandBlock<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("expand"), b.Const("block"));
    }

    /// <summary>
    /// Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`.
    /// </summary>
    public static void SetFillClear<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("fill"), b.Const("clear"));
    }

    /// <summary>
    /// Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`.
    /// </summary>
    public static void SetFillOutline<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("fill"), b.Const("outline"));
    }

    /// <summary>
    /// Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`.
    /// </summary>
    public static void SetFillSolid<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("fill"), b.Const("solid"));
    }

    /// <summary>
    /// Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`.
    /// </summary>
    public static void SetFillDefault<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("fill"), b.Const("default"));
    }

    /// <summary>
    /// The HTML form element or form element id. Used to submit a form when the button is not a child of the form.
    /// </summary>
    public static void SetForm<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> form) where T: IonButton
    {
        b.SetProperty(b.Const("form"), form);
    }

    /// <summary>
    /// The HTML form element or form element id. Used to submit a form when the button is not a child of the form.
    /// </summary>
    public static void SetForm<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<HTMLFormElement> form) where T: IonButton
    {
        b.SetProperty(b.Const("form"), form);
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> href) where T: IonButton
    {
        b.SetProperty(b.Const("href"), href);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> rel) where T: IonButton
    {
        b.SetProperty(b.Const("rel"), rel);
    }

    /// <summary>
    /// When using a router, it specifies the transition animation when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterAnimation<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, object, Animation>> routerAnimation) where T: IonButton
    {
        b.SetProperty(b.Const("routerAnimation"), routerAnimation);
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionForward<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("routerDirection"), b.Const("forward"));
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionBack<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("routerDirection"), b.Const("back"));
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionRoot<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("routerDirection"), b.Const("root"));
    }

    /// <summary>
    /// Set to `"round"` for a button with more rounded corners.
    /// </summary>
    public static void SetShapeRound<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("shape"), b.Const("round"));
    }

    /// <summary>
    /// Set to `"small"` for a button with less height and padding, to `"default"` for a button with the default height and padding, or to `"large"` for a button with more height and padding. By default the size is unset, unless the button is inside of an item, where the size is `"small"` by default. Set the size to `"default"` inside of an item to make it a standard size button.
    /// </summary>
    public static void SetSizeDefault<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("size"), b.Const("default"));
    }

    /// <summary>
    /// Set to `"small"` for a button with less height and padding, to `"default"` for a button with the default height and padding, or to `"large"` for a button with more height and padding. By default the size is unset, unless the button is inside of an item, where the size is `"small"` by default. Set the size to `"default"` inside of an item to make it a standard size button.
    /// </summary>
    public static void SetSizeSmall<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("size"), b.Const("small"));
    }

    /// <summary>
    /// Set to `"small"` for a button with less height and padding, to `"default"` for a button with the default height and padding, or to `"large"` for a button with more height and padding. By default the size is unset, unless the button is inside of an item, where the size is `"small"` by default. Set the size to `"default"` inside of an item to make it a standard size button.
    /// </summary>
    public static void SetSizeLarge<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("size"), b.Const("large"));
    }

    /// <summary>
    /// If `true`, activates a button with a heavier font weight.
    /// </summary>
    public static void SetStrong<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("strong"), b.Const(true));
    }
    public static void SetStrong<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> strong) where T: IonButton
    {
        b.SetProperty(b.Const("strong"), strong);
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> target) where T: IonButton
    {
        b.SetProperty(b.Const("target"), target);
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeSubmit<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("type"), b.Const("submit"));
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeReset<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("type"), b.Const("reset"));
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeButton<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonButton
    {
        b.SetProperty(b.Const("type"), b.Const("button"));
    }
}