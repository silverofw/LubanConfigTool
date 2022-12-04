using System.IO;
using Bright.Serialization;
using UnityEngine;
using cfg.item;
using cfg.monster;
using SimpleJSON;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        cfg.Tables tables = new cfg.Tables(LoadByteBuf);

        Item item = tables.TbItem.Get(10010);
        Debug.Log($"{item.Name} {item.Desc}");

        Monster monster = tables.TbMonster.Get(10000);
        Debug.Log($"{monster.Id}: {monster.Name}");

        Debug.Log("== load succ==");
    }
#if USE_BYTES_CONFIG
    private static ByteBuf LoadByteBuf(string file)
    {
        return new ByteBuf(File.ReadAllBytes($"{Application.dataPath}/Res/Configs/bytes/{file}.bytes"));
    }
#endif

#if USE_JSON_CONFIG
    private static JSONNode LoadByteBuf(string file)
    {
        return JSON.Parse(File.ReadAllText($"{Application.dataPath}/Res/Configs/json/{file}.json", System.Text.Encoding.UTF8));
    }
#endif
}
