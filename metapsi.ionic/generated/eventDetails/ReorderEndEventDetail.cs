
namespace Metapsi.Ionic;

public class ReorderEndEventDetail
{

    /// <summary>
    /// 
    /// </summary>
    public int from { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public int to { get; set; }
}
public static partial class ReorderEndEventDetailExtensions
{

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<object> complete(this Metapsi.Syntax.ObjBuilder<ReorderEndEventDetail> b, Metapsi.Syntax.Var<bool> data = null)
    {
        return b.Call<object>("complete", data);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<object> complete(this Metapsi.Syntax.ObjBuilder<ReorderEndEventDetail> b, Metapsi.Syntax.Var<System.Collections.Generic.List<object>> data = null)
    {
        return b.Call<object>("complete", data);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.ObjBuilder<object> complete(this Metapsi.Syntax.ObjBuilder<ReorderEndEventDetail> b)
    {
        return b.Call<object>("complete");
    }
}