using Metapsi.Syntax;
using Metapsi.Html;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

public class IonCol
{

    /// <summary>
    /// The amount to offset the column, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public string offset { get; set; }

    /// <summary>
    /// The amount to offset the column for lg screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public string offsetLg { get; set; }

    /// <summary>
    /// The amount to offset the column for md screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public string offsetMd { get; set; }

    /// <summary>
    /// The amount to offset the column for sm screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public string offsetSm { get; set; }

    /// <summary>
    /// The amount to offset the column for xl screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public string offsetXl { get; set; }

    /// <summary>
    /// The amount to offset the column for xs screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public string offsetXs { get; set; }

    /// <summary>
    /// The amount to pull the column, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public string pull { get; set; }

    /// <summary>
    /// The amount to pull the column for lg screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public string pullLg { get; set; }

    /// <summary>
    /// The amount to pull the column for md screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public string pullMd { get; set; }

    /// <summary>
    /// The amount to pull the column for sm screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public string pullSm { get; set; }

    /// <summary>
    /// The amount to pull the column for xl screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public string pullXl { get; set; }

    /// <summary>
    /// The amount to pull the column for xs screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public string pullXs { get; set; }

    /// <summary>
    /// The amount to push the column, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public string push { get; set; }

    /// <summary>
    /// The amount to push the column for lg screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public string pushLg { get; set; }

    /// <summary>
    /// The amount to push the column for md screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public string pushMd { get; set; }

    /// <summary>
    /// The amount to push the column for sm screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public string pushSm { get; set; }

    /// <summary>
    /// The amount to push the column for xl screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public string pushXl { get; set; }

    /// <summary>
    /// The amount to push the column for xs screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public string pushXs { get; set; }

    /// <summary>
    /// The size of the column, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public string size { get; set; }

    /// <summary>
    /// The size of the column for lg screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public string sizeLg { get; set; }

    /// <summary>
    /// The size of the column for md screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public string sizeMd { get; set; }

    /// <summary>
    /// The size of the column for sm screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public string sizeSm { get; set; }

    /// <summary>
    /// The size of the column for xl screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public string sizeXl { get; set; }

    /// <summary>
    /// The size of the column for xs screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public string sizeXs { get; set; }

    public static partial class Slot
    {
    }
    [System.Obsolete]
    public static partial class Method
    {
    }
}
public static partial class IonColControl
{
    /// <summary>
    /// Builds a "ion-col" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonCol(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonCol>> buildAttributes, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-col", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-col" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonCol(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children)
    {
        return b.IonicTag("ion-col", children);
    }

    /// <summary>
    /// Builds a "ion-col" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonCol(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonCol>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-col", buildAttributes, children);
    }

    /// <summary>
    /// Builds a "ion-col" HTML tag
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonCol(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children)
    {
        return b.IonicTag("ion-col", children);
    }

    /// <summary>
    /// The amount to offset the column, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffset(this Metapsi.Html.AttributesBuilder<IonCol> b, string offset)
    {
        b.SetAttribute("offset", offset);
    }

    /// <summary>
    /// The amount to offset the column for lg screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetLg(this Metapsi.Html.AttributesBuilder<IonCol> b, string offsetLg)
    {
        b.SetAttribute("offset-lg", offsetLg);
    }

    /// <summary>
    /// The amount to offset the column for md screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetMd(this Metapsi.Html.AttributesBuilder<IonCol> b, string offsetMd)
    {
        b.SetAttribute("offset-md", offsetMd);
    }

    /// <summary>
    /// The amount to offset the column for sm screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetSm(this Metapsi.Html.AttributesBuilder<IonCol> b, string offsetSm)
    {
        b.SetAttribute("offset-sm", offsetSm);
    }

    /// <summary>
    /// The amount to offset the column for xl screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetXl(this Metapsi.Html.AttributesBuilder<IonCol> b, string offsetXl)
    {
        b.SetAttribute("offset-xl", offsetXl);
    }

    /// <summary>
    /// The amount to offset the column for xs screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetXs(this Metapsi.Html.AttributesBuilder<IonCol> b, string offsetXs)
    {
        b.SetAttribute("offset-xs", offsetXs);
    }

    /// <summary>
    /// The amount to pull the column, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPull(this Metapsi.Html.AttributesBuilder<IonCol> b, string pull)
    {
        b.SetAttribute("pull", pull);
    }

    /// <summary>
    /// The amount to pull the column for lg screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullLg(this Metapsi.Html.AttributesBuilder<IonCol> b, string pullLg)
    {
        b.SetAttribute("pull-lg", pullLg);
    }

    /// <summary>
    /// The amount to pull the column for md screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullMd(this Metapsi.Html.AttributesBuilder<IonCol> b, string pullMd)
    {
        b.SetAttribute("pull-md", pullMd);
    }

    /// <summary>
    /// The amount to pull the column for sm screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullSm(this Metapsi.Html.AttributesBuilder<IonCol> b, string pullSm)
    {
        b.SetAttribute("pull-sm", pullSm);
    }

    /// <summary>
    /// The amount to pull the column for xl screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullXl(this Metapsi.Html.AttributesBuilder<IonCol> b, string pullXl)
    {
        b.SetAttribute("pull-xl", pullXl);
    }

    /// <summary>
    /// The amount to pull the column for xs screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullXs(this Metapsi.Html.AttributesBuilder<IonCol> b, string pullXs)
    {
        b.SetAttribute("pull-xs", pullXs);
    }

    /// <summary>
    /// The amount to push the column, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPush(this Metapsi.Html.AttributesBuilder<IonCol> b, string push)
    {
        b.SetAttribute("push", push);
    }

    /// <summary>
    /// The amount to push the column for lg screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushLg(this Metapsi.Html.AttributesBuilder<IonCol> b, string pushLg)
    {
        b.SetAttribute("push-lg", pushLg);
    }

    /// <summary>
    /// The amount to push the column for md screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushMd(this Metapsi.Html.AttributesBuilder<IonCol> b, string pushMd)
    {
        b.SetAttribute("push-md", pushMd);
    }

    /// <summary>
    /// The amount to push the column for sm screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushSm(this Metapsi.Html.AttributesBuilder<IonCol> b, string pushSm)
    {
        b.SetAttribute("push-sm", pushSm);
    }

    /// <summary>
    /// The amount to push the column for xl screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushXl(this Metapsi.Html.AttributesBuilder<IonCol> b, string pushXl)
    {
        b.SetAttribute("push-xl", pushXl);
    }

    /// <summary>
    /// The amount to push the column for xs screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushXs(this Metapsi.Html.AttributesBuilder<IonCol> b, string pushXs)
    {
        b.SetAttribute("push-xs", pushXs);
    }

    /// <summary>
    /// The size of the column, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSize(this Metapsi.Html.AttributesBuilder<IonCol> b, string size)
    {
        b.SetAttribute("size", size);
    }

    /// <summary>
    /// The size of the column for lg screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeLg(this Metapsi.Html.AttributesBuilder<IonCol> b, string sizeLg)
    {
        b.SetAttribute("size-lg", sizeLg);
    }

    /// <summary>
    /// The size of the column for md screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeMd(this Metapsi.Html.AttributesBuilder<IonCol> b, string sizeMd)
    {
        b.SetAttribute("size-md", sizeMd);
    }

    /// <summary>
    /// The size of the column for sm screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeSm(this Metapsi.Html.AttributesBuilder<IonCol> b, string sizeSm)
    {
        b.SetAttribute("size-sm", sizeSm);
    }

    /// <summary>
    /// The size of the column for xl screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeXl(this Metapsi.Html.AttributesBuilder<IonCol> b, string sizeXl)
    {
        b.SetAttribute("size-xl", sizeXl);
    }

    /// <summary>
    /// The size of the column for xs screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeXs(this Metapsi.Html.AttributesBuilder<IonCol> b, string sizeXs)
    {
        b.SetAttribute("size-xs", sizeXs);
    }
    /// <summary>
    /// Builds a virtual "ion-col" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonCol(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonCol>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-col", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-col" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonCol(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children)
    {
        return b.IonicNode("ion-col", children);
    }

    /// <summary>
    /// Builds a virtual "ion-col" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonCol(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonCol>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-col", buildProps, children);
    }

    /// <summary>
    /// Builds a virtual "ion-col" node
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonCol(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children)
    {
        return b.IonicNode("ion-col", children);
    }

    /// <summary>
    /// The amount to offset the column, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffset<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> offset) where T: IonCol
    {
        b.SetProperty(b.Const("offset"), offset);
    }

    /// <summary>
    /// The amount to offset the column for lg screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetLg<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> offsetLg) where T: IonCol
    {
        b.SetProperty(b.Const("offsetLg"), offsetLg);
    }

    /// <summary>
    /// The amount to offset the column for md screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetMd<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> offsetMd) where T: IonCol
    {
        b.SetProperty(b.Const("offsetMd"), offsetMd);
    }

    /// <summary>
    /// The amount to offset the column for sm screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetSm<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> offsetSm) where T: IonCol
    {
        b.SetProperty(b.Const("offsetSm"), offsetSm);
    }

    /// <summary>
    /// The amount to offset the column for xl screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetXl<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> offsetXl) where T: IonCol
    {
        b.SetProperty(b.Const("offsetXl"), offsetXl);
    }

    /// <summary>
    /// The amount to offset the column for xs screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetXs<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> offsetXs) where T: IonCol
    {
        b.SetProperty(b.Const("offsetXs"), offsetXs);
    }

    /// <summary>
    /// The amount to pull the column, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPull<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> pull) where T: IonCol
    {
        b.SetProperty(b.Const("pull"), pull);
    }

    /// <summary>
    /// The amount to pull the column for lg screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullLg<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> pullLg) where T: IonCol
    {
        b.SetProperty(b.Const("pullLg"), pullLg);
    }

    /// <summary>
    /// The amount to pull the column for md screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullMd<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> pullMd) where T: IonCol
    {
        b.SetProperty(b.Const("pullMd"), pullMd);
    }

    /// <summary>
    /// The amount to pull the column for sm screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullSm<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> pullSm) where T: IonCol
    {
        b.SetProperty(b.Const("pullSm"), pullSm);
    }

    /// <summary>
    /// The amount to pull the column for xl screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullXl<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> pullXl) where T: IonCol
    {
        b.SetProperty(b.Const("pullXl"), pullXl);
    }

    /// <summary>
    /// The amount to pull the column for xs screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullXs<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> pullXs) where T: IonCol
    {
        b.SetProperty(b.Const("pullXs"), pullXs);
    }

    /// <summary>
    /// The amount to push the column, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPush<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> push) where T: IonCol
    {
        b.SetProperty(b.Const("push"), push);
    }

    /// <summary>
    /// The amount to push the column for lg screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushLg<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> pushLg) where T: IonCol
    {
        b.SetProperty(b.Const("pushLg"), pushLg);
    }

    /// <summary>
    /// The amount to push the column for md screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushMd<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> pushMd) where T: IonCol
    {
        b.SetProperty(b.Const("pushMd"), pushMd);
    }

    /// <summary>
    /// The amount to push the column for sm screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushSm<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> pushSm) where T: IonCol
    {
        b.SetProperty(b.Const("pushSm"), pushSm);
    }

    /// <summary>
    /// The amount to push the column for xl screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushXl<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> pushXl) where T: IonCol
    {
        b.SetProperty(b.Const("pushXl"), pushXl);
    }

    /// <summary>
    /// The amount to push the column for xs screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushXs<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> pushXs) where T: IonCol
    {
        b.SetProperty(b.Const("pushXs"), pushXs);
    }

    /// <summary>
    /// The size of the column, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSize<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> size) where T: IonCol
    {
        b.SetProperty(b.Const("size"), size);
    }

    /// <summary>
    /// The size of the column for lg screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeLg<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> sizeLg) where T: IonCol
    {
        b.SetProperty(b.Const("sizeLg"), sizeLg);
    }

    /// <summary>
    /// The size of the column for md screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> sizeMd) where T: IonCol
    {
        b.SetProperty(b.Const("sizeMd"), sizeMd);
    }

    /// <summary>
    /// The size of the column for sm screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeSm<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> sizeSm) where T: IonCol
    {
        b.SetProperty(b.Const("sizeSm"), sizeSm);
    }

    /// <summary>
    /// The size of the column for xl screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeXl<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> sizeXl) where T: IonCol
    {
        b.SetProperty(b.Const("sizeXl"), sizeXl);
    }

    /// <summary>
    /// The size of the column for xs screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeXs<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> sizeXs) where T: IonCol
    {
        b.SetProperty(b.Const("sizeXs"), sizeXs);
    }
}
public static partial class IonColExtensions
{

    /// <summary>
    /// The amount to offset the column, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffset<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> offset) where T: IonCol
    {
        b.SetProperty(b.Const("offset"), offset);
    }

    /// <summary>
    /// The amount to offset the column for lg screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetLg<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> offsetLg) where T: IonCol
    {
        b.SetProperty(b.Const("offsetLg"), offsetLg);
    }

    /// <summary>
    /// The amount to offset the column for md screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetMd<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> offsetMd) where T: IonCol
    {
        b.SetProperty(b.Const("offsetMd"), offsetMd);
    }

    /// <summary>
    /// The amount to offset the column for sm screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetSm<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> offsetSm) where T: IonCol
    {
        b.SetProperty(b.Const("offsetSm"), offsetSm);
    }

    /// <summary>
    /// The amount to offset the column for xl screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetXl<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> offsetXl) where T: IonCol
    {
        b.SetProperty(b.Const("offsetXl"), offsetXl);
    }

    /// <summary>
    /// The amount to offset the column for xs screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetOffsetXs<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> offsetXs) where T: IonCol
    {
        b.SetProperty(b.Const("offsetXs"), offsetXs);
    }

    /// <summary>
    /// The amount to pull the column, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPull<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> pull) where T: IonCol
    {
        b.SetProperty(b.Const("pull"), pull);
    }

    /// <summary>
    /// The amount to pull the column for lg screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullLg<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> pullLg) where T: IonCol
    {
        b.SetProperty(b.Const("pullLg"), pullLg);
    }

    /// <summary>
    /// The amount to pull the column for md screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullMd<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> pullMd) where T: IonCol
    {
        b.SetProperty(b.Const("pullMd"), pullMd);
    }

    /// <summary>
    /// The amount to pull the column for sm screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullSm<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> pullSm) where T: IonCol
    {
        b.SetProperty(b.Const("pullSm"), pullSm);
    }

    /// <summary>
    /// The amount to pull the column for xl screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullXl<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> pullXl) where T: IonCol
    {
        b.SetProperty(b.Const("pullXl"), pullXl);
    }

    /// <summary>
    /// The amount to pull the column for xs screens, in terms of how many columns it should shift to the start of the total available.
    /// </summary>
    public static void SetPullXs<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> pullXs) where T: IonCol
    {
        b.SetProperty(b.Const("pullXs"), pullXs);
    }

    /// <summary>
    /// The amount to push the column, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPush<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> push) where T: IonCol
    {
        b.SetProperty(b.Const("push"), push);
    }

    /// <summary>
    /// The amount to push the column for lg screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushLg<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> pushLg) where T: IonCol
    {
        b.SetProperty(b.Const("pushLg"), pushLg);
    }

    /// <summary>
    /// The amount to push the column for md screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushMd<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> pushMd) where T: IonCol
    {
        b.SetProperty(b.Const("pushMd"), pushMd);
    }

    /// <summary>
    /// The amount to push the column for sm screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushSm<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> pushSm) where T: IonCol
    {
        b.SetProperty(b.Const("pushSm"), pushSm);
    }

    /// <summary>
    /// The amount to push the column for xl screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushXl<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> pushXl) where T: IonCol
    {
        b.SetProperty(b.Const("pushXl"), pushXl);
    }

    /// <summary>
    /// The amount to push the column for xs screens, in terms of how many columns it should shift to the end of the total available.
    /// </summary>
    public static void SetPushXs<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> pushXs) where T: IonCol
    {
        b.SetProperty(b.Const("pushXs"), pushXs);
    }

    /// <summary>
    /// The size of the column, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSize<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> size) where T: IonCol
    {
        b.SetProperty(b.Const("size"), size);
    }

    /// <summary>
    /// The size of the column for lg screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeLg<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> sizeLg) where T: IonCol
    {
        b.SetProperty(b.Const("sizeLg"), sizeLg);
    }

    /// <summary>
    /// The size of the column for md screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeMd<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> sizeMd) where T: IonCol
    {
        b.SetProperty(b.Const("sizeMd"), sizeMd);
    }

    /// <summary>
    /// The size of the column for sm screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeSm<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> sizeSm) where T: IonCol
    {
        b.SetProperty(b.Const("sizeSm"), sizeSm);
    }

    /// <summary>
    /// The size of the column for xl screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeXl<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> sizeXl) where T: IonCol
    {
        b.SetProperty(b.Const("sizeXl"), sizeXl);
    }

    /// <summary>
    /// The size of the column for xs screens, in terms of how many columns it should take up out of the total available. If `"auto"` is passed, the column will be the size of its content.
    /// </summary>
    public static void SetSizeXs<T>(this Metapsi.Syntax.ObjBuilder<T> b, Metapsi.Syntax.Var<string> sizeXs) where T: IonCol
    {
        b.SetProperty(b.Const("sizeXs"), sizeXs);
    }
}