using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonImg
{

    /// <summary>
    /// This attribute defines the alternative text describing the image. Users will see this text displayed if the image URL is wrong, the image is not in one of the supported formats, or if the image is not yet downloaded.
    /// </summary>
    public string alt { get; set; }

    /// <summary>
    /// The image URL. This attribute is mandatory for the `&lt;img&gt;` element.
    /// </summary>
    public string src { get; set; }

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
    }
}
public static partial class IonImgControl
{
    /// <summary>
    /// Builds a "ion-img" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonImg(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonImg>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-img", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-img" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonImg(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-img", children);
    }

    /// <summary>
    /// Builds a "ion-img" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonImg(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonImg>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-img", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-img" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonImg(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-img", children);
    }

    /// <summary>
    /// This attribute defines the alternative text describing the image. Users will see this text displayed if the image URL is wrong, the image is not in one of the supported formats, or if the image is not yet downloaded.
    /// </summary>
    public static void SetAlt(this Metapsi.Html.AttributesBuilder<IonImg> b, string alt)
    {
        b.SetAttribute("alt", alt);
    }

    /// <summary>
    /// The image URL. This attribute is mandatory for the `&lt;img&gt;` element.
    /// </summary>
    public static void SetSrc(this Metapsi.Html.AttributesBuilder<IonImg> b, string src)
    {
        b.SetAttribute("src", src);
    }
    /// <summary>
    /// Builds a virtual "ion-img" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonImg(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonImg>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-img", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-img" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonImg(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-img", children);
    }

    /// <summary>
    /// Builds a virtual "ion-img" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonImg(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonImg>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-img", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-img" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonImg(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-img", children);
    }

    /// <summary>
    /// This attribute defines the alternative text describing the image. Users will see this text displayed if the image URL is wrong, the image is not in one of the supported formats, or if the image is not yet downloaded.
    /// </summary>
    public static void SetAlt<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> alt) where T: IonImg
    {
        b.SetProperty(b.Const("alt"), alt);
    }

    /// <summary>
    /// The image URL. This attribute is mandatory for the `&lt;img&gt;` element.
    /// </summary>
    public static void SetSrc<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> src) where T: IonImg
    {
        b.SetProperty(b.Const("src"), src);
    }

    /// <summary>
    /// Emitted when the img fails to load
    /// </summary>
    public static void OnIonError<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonImg
    {
        b.SetProperty(b.Const("onionError"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the img fails to load
    /// </summary>
    [System.Obsolete]
    public static void OnIonError<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonImg
    {
        b.OnIonError(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the img fails to load
    /// </summary>
    public static void OnIonError<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonImg
    {
        b.SetProperty(b.Const("onionError"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the img fails to load
    /// </summary>
    [System.Obsolete]
    public static void OnIonError<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonImg
    {
        b.OnIonError(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the image has finished loading
    /// </summary>
    public static void OnIonImgDidLoad<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonImg
    {
        b.SetProperty(b.Const("onionImgDidLoad"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the image has finished loading
    /// </summary>
    [System.Obsolete]
    public static void OnIonImgDidLoad<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonImg
    {
        b.OnIonImgDidLoad(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the image has finished loading
    /// </summary>
    public static void OnIonImgDidLoad<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonImg
    {
        b.SetProperty(b.Const("onionImgDidLoad"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the image has finished loading
    /// </summary>
    [System.Obsolete]
    public static void OnIonImgDidLoad<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonImg
    {
        b.OnIonImgDidLoad(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the img src has been set
    /// </summary>
    public static void OnIonImgWillLoad<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonImg
    {
        b.SetProperty(b.Const("onionImgWillLoad"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the img src has been set
    /// </summary>
    [System.Obsolete]
    public static void OnIonImgWillLoad<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonImg
    {
        b.OnIonImgWillLoad(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the img src has been set
    /// </summary>
    public static void OnIonImgWillLoad<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonImg
    {
        b.SetProperty(b.Const("onionImgWillLoad"), b.Const(action));
    }

    /// <summary>
    /// Emitted when the img src has been set
    /// </summary>
    [System.Obsolete]
    public static void OnIonImgWillLoad<T, TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonImg
    {
        b.OnIonImgWillLoad(b.MakeAction(action));
    }
}
public static partial class IonImgExtensions
{

    /// <summary>
    /// This attribute defines the alternative text describing the image. Users will see this text displayed if the image URL is wrong, the image is not in one of the supported formats, or if the image is not yet downloaded.
    /// </summary>
    public static void SetAlt<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> alt) where T: IonImg
    {
        b.SetProperty(b.Const("alt"), alt);
    }

    /// <summary>
    /// The image URL. This attribute is mandatory for the `&lt;img&gt;` element.
    /// </summary>
    public static void SetSrc<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> src) where T: IonImg
    {
        b.SetProperty(b.Const("src"), src);
    }
}