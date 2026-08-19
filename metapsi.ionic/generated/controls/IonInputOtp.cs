using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonInputOtp
{

    /// <summary>
    /// Indicates whether and how the text value should be automatically capitalized as it is entered/edited by the user. Available options: `"off"`, `"none"`, `"on"`, `"sentences"`, `"words"`, `"characters"`.
    /// </summary>
    public string autocapitalize { get; set; }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public string color { get; set; }

    /// <summary>
    /// If `true`, the user cannot interact with the input.
    /// </summary>
    public bool disabled { get; set; }

    /// <summary>
    /// The fill for the input boxes. If `"solid"` the input boxes will have a background. If `"outline"` the input boxes will be transparent with a border.
    /// </summary>
    public string fill { get; set; }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.  For numbers (type="number"): "numeric" For text (type="text"): "text"
    /// </summary>
    public string inputmode { get; set; }

    /// <summary>
    /// The number of input boxes to display.
    /// </summary>
    public int length { get; set; }

    /// <summary>
    /// A regex pattern string for allowed characters. Defaults based on type.  For numbers (`type="number"`): `"[\p{N}]"` For text (`type="text"`): `"[\p{L}\p{N}]"`
    /// </summary>
    public string pattern { get; set; }

    /// <summary>
    /// If `true`, the user cannot modify the value.
    /// </summary>
    public bool @readonly { get; set; }

    /// <summary>
    /// Where separators should be shown between input boxes. Can be a comma-separated string or an array of numbers.  For example: `"3"` will show a separator after the 3rd input box. `[1,4]` will show a separator after the 1st and 4th input boxes. `"all"` will show a separator between every input box.
    /// </summary>
    public object separators { get; set; }

    /// <summary>
    /// The shape of the input boxes. If "round" they will have an increased border radius. If "rectangular" they will have no border radius. If "soft" they will have a soft border radius.
    /// </summary>
    public string shape { get; set; }

    /// <summary>
    /// The size of the input boxes.
    /// </summary>
    public string size { get; set; }

    /// <summary>
    /// The type of input allowed in the input boxes.
    /// </summary>
    public string type { get; set; }

    /// <summary>
    /// The value of the input group.
    /// </summary>
    public object value { get; set; }

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
        /// <summary>
        /// Sets focus to an input box.
        /// </summary>
        [System.Obsolete("Use the typed methods on ObjBuilder<IonInputOtp> instead")]
        public const string SetFocus = "setFocus";
    }
}
public static partial class IonInputOtpControl
{
    /// <summary>
    /// Builds a "ion-input-otp" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonInputOtp(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonInputOtp>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-input-otp", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-input-otp" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonInputOtp(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-input-otp", children);
    }

    /// <summary>
    /// Builds a "ion-input-otp" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonInputOtp(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonInputOtp>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-input-otp", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-input-otp" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonInputOtp(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-input-otp", children);
    }

    /// <summary>
    /// Indicates whether and how the text value should be automatically capitalized as it is entered/edited by the user. Available options: `"off"`, `"none"`, `"on"`, `"sentences"`, `"words"`, `"characters"`.
    /// </summary>
    public static void SetAutocapitalize(this Metapsi.Html.AttributesBuilder<IonInputOtp> b, string autocapitalize)
    {
        b.SetAttribute("autocapitalize", autocapitalize);
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary(this Metapsi.Html.AttributesBuilder<IonInputOtp> b)
    {
        b.SetAttribute("color", "primary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary(this Metapsi.Html.AttributesBuilder<IonInputOtp> b)
    {
        b.SetAttribute("color", "secondary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary(this Metapsi.Html.AttributesBuilder<IonInputOtp> b)
    {
        b.SetAttribute("color", "tertiary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess(this Metapsi.Html.AttributesBuilder<IonInputOtp> b)
    {
        b.SetAttribute("color", "success");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning(this Metapsi.Html.AttributesBuilder<IonInputOtp> b)
    {
        b.SetAttribute("color", "warning");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger(this Metapsi.Html.AttributesBuilder<IonInputOtp> b)
    {
        b.SetAttribute("color", "danger");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight(this Metapsi.Html.AttributesBuilder<IonInputOtp> b)
    {
        b.SetAttribute("color", "light");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium(this Metapsi.Html.AttributesBuilder<IonInputOtp> b)
    {
        b.SetAttribute("color", "medium");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark(this Metapsi.Html.AttributesBuilder<IonInputOtp> b)
    {
        b.SetAttribute("color", "dark");
    }

    /// <summary>
    /// If `true`, the user cannot interact with the input.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonInputOtp> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// If `true`, the user cannot interact with the input.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonInputOtp> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// The fill for the input boxes. If `"solid"` the input boxes will have a background. If `"outline"` the input boxes will be transparent with a border.
    /// </summary>
    public static void SetFillOutline(this Metapsi.Html.AttributesBuilder<IonInputOtp> b)
    {
        b.SetAttribute("fill", "outline");
    }

    /// <summary>
    /// The fill for the input boxes. If `"solid"` the input boxes will have a background. If `"outline"` the input boxes will be transparent with a border.
    /// </summary>
    public static void SetFillSolid(this Metapsi.Html.AttributesBuilder<IonInputOtp> b)
    {
        b.SetAttribute("fill", "solid");
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.  For numbers (type="number"): "numeric" For text (type="text"): "text"
    /// </summary>
    public static void SetInputmodeEmail(this Metapsi.Html.AttributesBuilder<IonInputOtp> b)
    {
        b.SetAttribute("inputmode", "email");
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.  For numbers (type="number"): "numeric" For text (type="text"): "text"
    /// </summary>
    public static void SetInputmodeTel(this Metapsi.Html.AttributesBuilder<IonInputOtp> b)
    {
        b.SetAttribute("inputmode", "tel");
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.  For numbers (type="number"): "numeric" For text (type="text"): "text"
    /// </summary>
    public static void SetInputmodeUrl(this Metapsi.Html.AttributesBuilder<IonInputOtp> b)
    {
        b.SetAttribute("inputmode", "url");
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.  For numbers (type="number"): "numeric" For text (type="text"): "text"
    /// </summary>
    public static void SetInputmodeSearch(this Metapsi.Html.AttributesBuilder<IonInputOtp> b)
    {
        b.SetAttribute("inputmode", "search");
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.  For numbers (type="number"): "numeric" For text (type="text"): "text"
    /// </summary>
    public static void SetInputmodeNone(this Metapsi.Html.AttributesBuilder<IonInputOtp> b)
    {
        b.SetAttribute("inputmode", "none");
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.  For numbers (type="number"): "numeric" For text (type="text"): "text"
    /// </summary>
    public static void SetInputmodeText(this Metapsi.Html.AttributesBuilder<IonInputOtp> b)
    {
        b.SetAttribute("inputmode", "text");
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.  For numbers (type="number"): "numeric" For text (type="text"): "text"
    /// </summary>
    public static void SetInputmodeNumeric(this Metapsi.Html.AttributesBuilder<IonInputOtp> b)
    {
        b.SetAttribute("inputmode", "numeric");
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.  For numbers (type="number"): "numeric" For text (type="text"): "text"
    /// </summary>
    public static void SetInputmodeDecimal(this Metapsi.Html.AttributesBuilder<IonInputOtp> b)
    {
        b.SetAttribute("inputmode", "decimal");
    }

    /// <summary>
    /// The number of input boxes to display.
    /// </summary>
    public static void SetLength(this Metapsi.Html.AttributesBuilder<IonInputOtp> b, string length)
    {
        b.SetAttribute("length", length);
    }

    /// <summary>
    /// A regex pattern string for allowed characters. Defaults based on type.  For numbers (`type="number"`): `"[\p{N}]"` For text (`type="text"`): `"[\p{L}\p{N}]"`
    /// </summary>
    public static void SetPattern(this Metapsi.Html.AttributesBuilder<IonInputOtp> b, string pattern)
    {
        b.SetAttribute("pattern", pattern);
    }

    /// <summary>
    /// If `true`, the user cannot modify the value.
    /// </summary>
    public static void SetReadonly(this Metapsi.Html.AttributesBuilder<IonInputOtp> b, bool @readonly)
    {
        if (@readonly) b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// If `true`, the user cannot modify the value.
    /// </summary>
    public static void SetReadonly(this Metapsi.Html.AttributesBuilder<IonInputOtp> b)
    {
        b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// Where separators should be shown between input boxes. Can be a comma-separated string or an array of numbers.  For example: `"3"` will show a separator after the 3rd input box. `[1,4]` will show a separator after the 1st and 4th input boxes. `"all"` will show a separator between every input box.
    /// </summary>
    public static void SetSeparators(this Metapsi.Html.AttributesBuilder<IonInputOtp> b, string separators)
    {
        b.SetAttribute("separators", separators);
    }

    /// <summary>
    /// The shape of the input boxes. If "round" they will have an increased border radius. If "rectangular" they will have no border radius. If "soft" they will have a soft border radius.
    /// </summary>
    public static void SetShapeRound(this Metapsi.Html.AttributesBuilder<IonInputOtp> b)
    {
        b.SetAttribute("shape", "round");
    }

    /// <summary>
    /// The shape of the input boxes. If "round" they will have an increased border radius. If "rectangular" they will have no border radius. If "soft" they will have a soft border radius.
    /// </summary>
    public static void SetShapeRectangular(this Metapsi.Html.AttributesBuilder<IonInputOtp> b)
    {
        b.SetAttribute("shape", "rectangular");
    }

    /// <summary>
    /// The shape of the input boxes. If "round" they will have an increased border radius. If "rectangular" they will have no border radius. If "soft" they will have a soft border radius.
    /// </summary>
    public static void SetShapeSoft(this Metapsi.Html.AttributesBuilder<IonInputOtp> b)
    {
        b.SetAttribute("shape", "soft");
    }

    /// <summary>
    /// The size of the input boxes.
    /// </summary>
    public static void SetSizeMedium(this Metapsi.Html.AttributesBuilder<IonInputOtp> b)
    {
        b.SetAttribute("size", "medium");
    }

    /// <summary>
    /// The size of the input boxes.
    /// </summary>
    public static void SetSizeSmall(this Metapsi.Html.AttributesBuilder<IonInputOtp> b)
    {
        b.SetAttribute("size", "small");
    }

    /// <summary>
    /// The size of the input boxes.
    /// </summary>
    public static void SetSizeLarge(this Metapsi.Html.AttributesBuilder<IonInputOtp> b)
    {
        b.SetAttribute("size", "large");
    }

    /// <summary>
    /// The type of input allowed in the input boxes.
    /// </summary>
    public static void SetTypeNumber(this Metapsi.Html.AttributesBuilder<IonInputOtp> b)
    {
        b.SetAttribute("type", "number");
    }

    /// <summary>
    /// The type of input allowed in the input boxes.
    /// </summary>
    public static void SetTypeText(this Metapsi.Html.AttributesBuilder<IonInputOtp> b)
    {
        b.SetAttribute("type", "text");
    }

    /// <summary>
    /// The value of the input group.
    /// </summary>
    public static void SetValue(this Metapsi.Html.AttributesBuilder<IonInputOtp> b, string value)
    {
        b.SetAttribute("value", value);
    }
    /// <summary>
    /// Builds a virtual "ion-input-otp" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonInputOtp(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonInputOtp>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-input-otp", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-input-otp" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonInputOtp(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-input-otp", children);
    }

    /// <summary>
    /// Builds a virtual "ion-input-otp" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonInputOtp(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonInputOtp>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-input-otp", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-input-otp" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonInputOtp(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-input-otp", children);
    }

    /// <summary>
    /// Indicates whether and how the text value should be automatically capitalized as it is entered/edited by the user. Available options: `"off"`, `"none"`, `"on"`, `"sentences"`, `"words"`, `"characters"`.
    /// </summary>
    public static void SetAutocapitalize<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> autocapitalize) where T: IonInputOtp
    {
        b.SetProperty(b.Const("autocapitalize"), autocapitalize);
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("color"), b.Const("primary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("color"), b.Const("secondary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("color"), b.Const("tertiary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("color"), b.Const("success"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("color"), b.Const("warning"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("color"), b.Const("danger"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("color"), b.Const("light"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("color"), b.Const("medium"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("color"), b.Const("dark"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> color) where T: IonInputOtp
    {
        b.SetProperty(b.Const("color"), color);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the input.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("disabled"), b.Const(true));
    }
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonInputOtp
    {
        b.SetProperty(b.Const("disabled"), disabled);
    }

    /// <summary>
    /// The fill for the input boxes. If `"solid"` the input boxes will have a background. If `"outline"` the input boxes will be transparent with a border.
    /// </summary>
    public static void SetFillOutline<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("fill"), b.Const("outline"));
    }

    /// <summary>
    /// The fill for the input boxes. If `"solid"` the input boxes will have a background. If `"outline"` the input boxes will be transparent with a border.
    /// </summary>
    public static void SetFillSolid<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("fill"), b.Const("solid"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.  For numbers (type="number"): "numeric" For text (type="text"): "text"
    /// </summary>
    public static void SetInputmodeEmail<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("inputmode"), b.Const("email"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.  For numbers (type="number"): "numeric" For text (type="text"): "text"
    /// </summary>
    public static void SetInputmodeTel<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("inputmode"), b.Const("tel"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.  For numbers (type="number"): "numeric" For text (type="text"): "text"
    /// </summary>
    public static void SetInputmodeUrl<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("inputmode"), b.Const("url"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.  For numbers (type="number"): "numeric" For text (type="text"): "text"
    /// </summary>
    public static void SetInputmodeSearch<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("inputmode"), b.Const("search"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.  For numbers (type="number"): "numeric" For text (type="text"): "text"
    /// </summary>
    public static void SetInputmodeNone<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("inputmode"), b.Const("none"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.  For numbers (type="number"): "numeric" For text (type="text"): "text"
    /// </summary>
    public static void SetInputmodeText<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("inputmode"), b.Const("text"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.  For numbers (type="number"): "numeric" For text (type="text"): "text"
    /// </summary>
    public static void SetInputmodeNumeric<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("inputmode"), b.Const("numeric"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.  For numbers (type="number"): "numeric" For text (type="text"): "text"
    /// </summary>
    public static void SetInputmodeDecimal<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("inputmode"), b.Const("decimal"));
    }

    /// <summary>
    /// The number of input boxes to display.
    /// </summary>
    public static void SetLength<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> length) where T: IonInputOtp
    {
        b.SetProperty(b.Const("length"), length);
    }

    /// <summary>
    /// A regex pattern string for allowed characters. Defaults based on type.  For numbers (`type="number"`): `"[\p{N}]"` For text (`type="text"`): `"[\p{L}\p{N}]"`
    /// </summary>
    public static void SetPattern<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> pattern) where T: IonInputOtp
    {
        b.SetProperty(b.Const("pattern"), pattern);
    }

    /// <summary>
    /// If `true`, the user cannot modify the value.
    /// </summary>
    public static void SetReadonly<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("readonly"), b.Const(true));
    }
    public static void SetReadonly<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> @readonly) where T: IonInputOtp
    {
        b.SetProperty(b.Const("readonly"), @readonly);
    }

    /// <summary>
    /// Where separators should be shown between input boxes. Can be a comma-separated string or an array of numbers.  For example: `"3"` will show a separator after the 3rd input box. `[1,4]` will show a separator after the 1st and 4th input boxes. `"all"` will show a separator between every input box.
    /// </summary>
    public static void SetSeparators<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> separators) where T: IonInputOtp
    {
        b.SetProperty(b.Const("separators"), separators);
    }

    /// <summary>
    /// Where separators should be shown between input boxes. Can be a comma-separated string or an array of numbers.  For example: `"3"` will show a separator after the 3rd input box. `[1,4]` will show a separator after the 1st and 4th input boxes. `"all"` will show a separator between every input box.
    /// </summary>
    public static void SetSeparators<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<int>> separators) where T: IonInputOtp
    {
        b.SetProperty(b.Const("separators"), separators);
    }

    /// <summary>
    /// The shape of the input boxes. If "round" they will have an increased border radius. If "rectangular" they will have no border radius. If "soft" they will have a soft border radius.
    /// </summary>
    public static void SetShapeRound<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("shape"), b.Const("round"));
    }

    /// <summary>
    /// The shape of the input boxes. If "round" they will have an increased border radius. If "rectangular" they will have no border radius. If "soft" they will have a soft border radius.
    /// </summary>
    public static void SetShapeRectangular<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("shape"), b.Const("rectangular"));
    }

    /// <summary>
    /// The shape of the input boxes. If "round" they will have an increased border radius. If "rectangular" they will have no border radius. If "soft" they will have a soft border radius.
    /// </summary>
    public static void SetShapeSoft<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("shape"), b.Const("soft"));
    }

    /// <summary>
    /// The size of the input boxes.
    /// </summary>
    public static void SetSizeMedium<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("size"), b.Const("medium"));
    }

    /// <summary>
    /// The size of the input boxes.
    /// </summary>
    public static void SetSizeSmall<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("size"), b.Const("small"));
    }

    /// <summary>
    /// The size of the input boxes.
    /// </summary>
    public static void SetSizeLarge<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("size"), b.Const("large"));
    }

    /// <summary>
    /// The type of input allowed in the input boxes.
    /// </summary>
    public static void SetTypeNumber<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("type"), b.Const("number"));
    }

    /// <summary>
    /// The type of input allowed in the input boxes.
    /// </summary>
    public static void SetTypeText<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("type"), b.Const("text"));
    }

    /// <summary>
    /// The value of the input group.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> value) where T: IonInputOtp
    {
        b.SetProperty(b.Const("value"), value);
    }

    /// <summary>
    /// The value of the input group.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> value) where T: IonInputOtp
    {
        b.SetProperty(b.Const("value"), value);
    }

    /// <summary>
    /// Emitted when the input group loses focus.
    /// </summary>
    public static void OnIonBlur<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonInputOtp
    {
        b.SetProperty(b.Const("onionBlur"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the input group loses focus.
    /// </summary>
    [System.Obsolete]
    public static void OnIonBlur<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonInputOtp
    {
        b.OnIonBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the input group loses focus.
    /// </summary>
    public static void OnIonBlur<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonInputOtp
    {
        b.SetProperty(b.Const("onionBlur"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the input group loses focus.
    /// </summary>
    [System.Obsolete]
    public static void OnIonBlur<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonInputOtp
    {
        b.OnIonBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the input group loses focus.
    /// </summary>
    public static void OnIonBlur<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<FocusEvent>>> action) where T: IonInputOtp
    {
        b.SetProperty(b.Const("onionBlur"), b.Const(action));
    }

    /// <summary>
    /// The `ionChange` event is fired when the user modifies the input's value. Unlike the `ionInput` event, the `ionChange` event is only fired when changes are committed, not as the user types.  The `ionChange` event fires when the `&lt;ion-input-otp&gt;` component loses focus after its value has changed.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonInputOtp
    {
        b.SetProperty(b.Const("onionChange"), b.Const(action));
    }

    /// <summary>
    /// The `ionChange` event is fired when the user modifies the input's value. Unlike the `ionInput` event, the `ionChange` event is only fired when changes are committed, not as the user types.  The `ionChange` event fires when the `&lt;ion-input-otp&gt;` component loses focus after its value has changed.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    [System.Obsolete]
    public static void OnIonChange<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonInputOtp
    {
        b.OnIonChange(b.MakeAction(action));
    }

    /// <summary>
    /// The `ionChange` event is fired when the user modifies the input's value. Unlike the `ionInput` event, the `ionChange` event is only fired when changes are committed, not as the user types.  The `ionChange` event fires when the `&lt;ion-input-otp&gt;` component loses focus after its value has changed.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonInputOtp
    {
        b.SetProperty(b.Const("onionChange"), b.Const(action));
    }

    /// <summary>
    /// The `ionChange` event is fired when the user modifies the input's value. Unlike the `ionInput` event, the `ionChange` event is only fired when changes are committed, not as the user types.  The `ionChange` event fires when the `&lt;ion-input-otp&gt;` component loses focus after its value has changed.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    [System.Obsolete]
    public static void OnIonChange<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonInputOtp
    {
        b.OnIonChange(b.MakeAction(action));
    }

    /// <summary>
    /// The `ionChange` event is fired when the user modifies the input's value. Unlike the `ionInput` event, the `ionChange` event is only fired when changes are committed, not as the user types.  The `ionChange` event fires when the `&lt;ion-input-otp&gt;` component loses focus after its value has changed.  This event will not emit when programmatically setting the `value` property.
    /// </summary>
    public static void OnIonChange<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<InputOtpChangeEventDetail>>> action) where T: IonInputOtp
    {
        b.SetProperty(b.Const("onionChange"), b.Const(action));
    }

    /// <summary>
    /// Emitted when all input boxes have been filled with valid values.
    /// </summary>
    public static void OnIonComplete<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonInputOtp
    {
        b.SetProperty(b.Const("onionComplete"), b.Const(action));
    }

    /// <summary>
    /// Emitted when all input boxes have been filled with valid values.
    /// </summary>
    [System.Obsolete]
    public static void OnIonComplete<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonInputOtp
    {
        b.OnIonComplete(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when all input boxes have been filled with valid values.
    /// </summary>
    public static void OnIonComplete<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonInputOtp
    {
        b.SetProperty(b.Const("onionComplete"), b.Const(action));
    }

    /// <summary>
    /// Emitted when all input boxes have been filled with valid values.
    /// </summary>
    [System.Obsolete]
    public static void OnIonComplete<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonInputOtp
    {
        b.OnIonComplete(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when all input boxes have been filled with valid values.
    /// </summary>
    public static void OnIonComplete<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<InputOtpCompleteEventDetail>>> action) where T: IonInputOtp
    {
        b.SetProperty(b.Const("onionComplete"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the input group has focus.
    /// </summary>
    public static void OnIonFocus<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonInputOtp
    {
        b.SetProperty(b.Const("onionFocus"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the input group has focus.
    /// </summary>
    [System.Obsolete]
    public static void OnIonFocus<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonInputOtp
    {
        b.OnIonFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the input group has focus.
    /// </summary>
    public static void OnIonFocus<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonInputOtp
    {
        b.SetProperty(b.Const("onionFocus"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the input group has focus.
    /// </summary>
    [System.Obsolete]
    public static void OnIonFocus<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonInputOtp
    {
        b.OnIonFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the input group has focus.
    /// </summary>
    public static void OnIonFocus<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<FocusEvent>>> action) where T: IonInputOtp
    {
        b.SetProperty(b.Const("onionFocus"), b.Const(action));
    }

    /// <summary>
    /// The `ionInput` event is fired each time the user modifies the input's value. Unlike the `ionChange` event, the `ionInput` event is fired for each alteration to the input's value. This typically happens for each keystroke as the user types.  For elements that accept text input (`type=text`, `type=tel`, etc.), the interface is [`InputEvent`](https://developer.mozilla.org/en-US/docs/Web/API/InputEvent); for others, the interface is [`Event`](https://developer.mozilla.org/en-US/docs/Web/API/Event). If the input is cleared on edit, the type is `null`.
    /// </summary>
    public static void OnIonInput<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonInputOtp
    {
        b.SetProperty(b.Const("onionInput"), b.Const(action));
    }

    /// <summary>
    /// The `ionInput` event is fired each time the user modifies the input's value. Unlike the `ionChange` event, the `ionInput` event is fired for each alteration to the input's value. This typically happens for each keystroke as the user types.  For elements that accept text input (`type=text`, `type=tel`, etc.), the interface is [`InputEvent`](https://developer.mozilla.org/en-US/docs/Web/API/InputEvent); for others, the interface is [`Event`](https://developer.mozilla.org/en-US/docs/Web/API/Event). If the input is cleared on edit, the type is `null`.
    /// </summary>
    [System.Obsolete]
    public static void OnIonInput<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonInputOtp
    {
        b.OnIonInput(b.MakeAction(action));
    }

    /// <summary>
    /// The `ionInput` event is fired each time the user modifies the input's value. Unlike the `ionChange` event, the `ionInput` event is fired for each alteration to the input's value. This typically happens for each keystroke as the user types.  For elements that accept text input (`type=text`, `type=tel`, etc.), the interface is [`InputEvent`](https://developer.mozilla.org/en-US/docs/Web/API/InputEvent); for others, the interface is [`Event`](https://developer.mozilla.org/en-US/docs/Web/API/Event). If the input is cleared on edit, the type is `null`.
    /// </summary>
    public static void OnIonInput<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonInputOtp
    {
        b.SetProperty(b.Const("onionInput"), b.Const(action));
    }

    /// <summary>
    /// The `ionInput` event is fired each time the user modifies the input's value. Unlike the `ionChange` event, the `ionInput` event is fired for each alteration to the input's value. This typically happens for each keystroke as the user types.  For elements that accept text input (`type=text`, `type=tel`, etc.), the interface is [`InputEvent`](https://developer.mozilla.org/en-US/docs/Web/API/InputEvent); for others, the interface is [`Event`](https://developer.mozilla.org/en-US/docs/Web/API/Event). If the input is cleared on edit, the type is `null`.
    /// </summary>
    [System.Obsolete]
    public static void OnIonInput<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonInputOtp
    {
        b.OnIonInput(b.MakeAction(action));
    }

    /// <summary>
    /// The `ionInput` event is fired each time the user modifies the input's value. Unlike the `ionChange` event, the `ionInput` event is fired for each alteration to the input's value. This typically happens for each keystroke as the user types.  For elements that accept text input (`type=text`, `type=tel`, etc.), the interface is [`InputEvent`](https://developer.mozilla.org/en-US/docs/Web/API/InputEvent); for others, the interface is [`Event`](https://developer.mozilla.org/en-US/docs/Web/API/Event). If the input is cleared on edit, the type is `null`.
    /// </summary>
    public static void OnIonInput<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, CustomEvent<InputOtpInputEventDetail>>> action) where T: IonInputOtp
    {
        b.SetProperty(b.Const("onionInput"), b.Const(action));
    }
}
public static partial class IonInputOtpExtensions
{

    /// <summary>
    /// Indicates whether and how the text value should be automatically capitalized as it is entered/edited by the user. Available options: `"off"`, `"none"`, `"on"`, `"sentences"`, `"words"`, `"characters"`.
    /// </summary>
    public static void SetAutocapitalize<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> autocapitalize) where T: IonInputOtp
    {
        b.SetProperty(b.Const("autocapitalize"), autocapitalize);
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("color"), b.Const("primary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("color"), b.Const("secondary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("color"), b.Const("tertiary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("color"), b.Const("success"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("color"), b.Const("warning"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("color"), b.Const("danger"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("color"), b.Const("light"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("color"), b.Const("medium"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("color"), b.Const("dark"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> color) where T: IonInputOtp
    {
        b.SetProperty(b.Const("color"), color);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the input.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("disabled"), b.Const(true));
    }
    public static void SetDisabled<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonInputOtp
    {
        b.SetProperty(b.Const("disabled"), disabled);
    }

    /// <summary>
    /// The fill for the input boxes. If `"solid"` the input boxes will have a background. If `"outline"` the input boxes will be transparent with a border.
    /// </summary>
    public static void SetFillOutline<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("fill"), b.Const("outline"));
    }

    /// <summary>
    /// The fill for the input boxes. If `"solid"` the input boxes will have a background. If `"outline"` the input boxes will be transparent with a border.
    /// </summary>
    public static void SetFillSolid<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("fill"), b.Const("solid"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.  For numbers (type="number"): "numeric" For text (type="text"): "text"
    /// </summary>
    public static void SetInputmodeEmail<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("inputmode"), b.Const("email"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.  For numbers (type="number"): "numeric" For text (type="text"): "text"
    /// </summary>
    public static void SetInputmodeTel<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("inputmode"), b.Const("tel"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.  For numbers (type="number"): "numeric" For text (type="text"): "text"
    /// </summary>
    public static void SetInputmodeUrl<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("inputmode"), b.Const("url"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.  For numbers (type="number"): "numeric" For text (type="text"): "text"
    /// </summary>
    public static void SetInputmodeSearch<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("inputmode"), b.Const("search"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.  For numbers (type="number"): "numeric" For text (type="text"): "text"
    /// </summary>
    public static void SetInputmodeNone<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("inputmode"), b.Const("none"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.  For numbers (type="number"): "numeric" For text (type="text"): "text"
    /// </summary>
    public static void SetInputmodeText<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("inputmode"), b.Const("text"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.  For numbers (type="number"): "numeric" For text (type="text"): "text"
    /// </summary>
    public static void SetInputmodeNumeric<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("inputmode"), b.Const("numeric"));
    }

    /// <summary>
    /// A hint to the browser for which keyboard to display. Possible values: `"none"`, `"text"`, `"tel"`, `"url"`, `"email"`, `"numeric"`, `"decimal"`, and `"search"`.  For numbers (type="number"): "numeric" For text (type="text"): "text"
    /// </summary>
    public static void SetInputmodeDecimal<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("inputmode"), b.Const("decimal"));
    }

    /// <summary>
    /// The number of input boxes to display.
    /// </summary>
    public static void SetLength<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<int> length) where T: IonInputOtp
    {
        b.SetProperty(b.Const("length"), length);
    }

    /// <summary>
    /// A regex pattern string for allowed characters. Defaults based on type.  For numbers (`type="number"`): `"[\p{N}]"` For text (`type="text"`): `"[\p{L}\p{N}]"`
    /// </summary>
    public static void SetPattern<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> pattern) where T: IonInputOtp
    {
        b.SetProperty(b.Const("pattern"), pattern);
    }

    /// <summary>
    /// If `true`, the user cannot modify the value.
    /// </summary>
    public static void SetReadonly<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("readonly"), b.Const(true));
    }
    public static void SetReadonly<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<bool> @readonly) where T: IonInputOtp
    {
        b.SetProperty(b.Const("readonly"), @readonly);
    }

    /// <summary>
    /// Where separators should be shown between input boxes. Can be a comma-separated string or an array of numbers.  For example: `"3"` will show a separator after the 3rd input box. `[1,4]` will show a separator after the 1st and 4th input boxes. `"all"` will show a separator between every input box.
    /// </summary>
    public static void SetSeparators<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> separators) where T: IonInputOtp
    {
        b.SetProperty(b.Const("separators"), separators);
    }

    /// <summary>
    /// Where separators should be shown between input boxes. Can be a comma-separated string or an array of numbers.  For example: `"3"` will show a separator after the 3rd input box. `[1,4]` will show a separator after the 1st and 4th input boxes. `"all"` will show a separator between every input box.
    /// </summary>
    public static void SetSeparators<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<int>> separators) where T: IonInputOtp
    {
        b.SetProperty(b.Const("separators"), separators);
    }

    /// <summary>
    /// The shape of the input boxes. If "round" they will have an increased border radius. If "rectangular" they will have no border radius. If "soft" they will have a soft border radius.
    /// </summary>
    public static void SetShapeRound<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("shape"), b.Const("round"));
    }

    /// <summary>
    /// The shape of the input boxes. If "round" they will have an increased border radius. If "rectangular" they will have no border radius. If "soft" they will have a soft border radius.
    /// </summary>
    public static void SetShapeRectangular<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("shape"), b.Const("rectangular"));
    }

    /// <summary>
    /// The shape of the input boxes. If "round" they will have an increased border radius. If "rectangular" they will have no border radius. If "soft" they will have a soft border radius.
    /// </summary>
    public static void SetShapeSoft<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("shape"), b.Const("soft"));
    }

    /// <summary>
    /// The size of the input boxes.
    /// </summary>
    public static void SetSizeMedium<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("size"), b.Const("medium"));
    }

    /// <summary>
    /// The size of the input boxes.
    /// </summary>
    public static void SetSizeSmall<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("size"), b.Const("small"));
    }

    /// <summary>
    /// The size of the input boxes.
    /// </summary>
    public static void SetSizeLarge<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("size"), b.Const("large"));
    }

    /// <summary>
    /// The type of input allowed in the input boxes.
    /// </summary>
    public static void SetTypeNumber<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("type"), b.Const("number"));
    }

    /// <summary>
    /// The type of input allowed in the input boxes.
    /// </summary>
    public static void SetTypeText<T>(this Metapsi.Syntax.ObjBuilder<T> b) where T: IonInputOtp
    {
        b.SetProperty(b.Const("type"), b.Const("text"));
    }

    /// <summary>
    /// The value of the input group.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> value) where T: IonInputOtp
    {
        b.SetProperty(b.Const("value"), value);
    }

    /// <summary>
    /// The value of the input group.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<int> value) where T: IonInputOtp
    {
        b.SetProperty(b.Const("value"), value);
    }

    /// <summary>
    /// Sets focus to an input box.
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<Promise> setFocus(this Metapsi.Syntax.ObjBuilder<IonInputOtp> b, Metapsi.Syntax.Var<int> index = null)
    {
        return b.Call<Promise>("setFocus", index);
    }
}