//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;



namespace cfg
{ 
public partial class Tables
{
    public item.TbItem TbItem {get; }
    public monster.TbMonster TbMonster {get; }

    public Tables(System.Func<string, ByteBuf> loader)
    {
        var tables = new System.Collections.Generic.Dictionary<string, object>();
        TbItem = new item.TbItem(loader("item_tbitem")); 
        tables.Add("item.TbItem", TbItem);
        TbMonster = new monster.TbMonster(loader("monster_tbmonster")); 
        tables.Add("monster.TbMonster", TbMonster);

        PostInit();
        TbItem.Resolve(tables); 
        TbMonster.Resolve(tables); 
        PostResolve();
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        TbItem.TranslateText(translator); 
        TbMonster.TranslateText(translator); 
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}