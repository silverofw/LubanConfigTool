using System.IO;
using Bright.Serialization;
using UnityEngine;
using cfg.item;
using cfg.monster;

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

    private static ByteBuf LoadByteBuf(string file)
    {
        return new ByteBuf(File.ReadAllBytes($"{Application.dataPath}/Res/Configs/bytes/{file}.bytes"));
    }
}
