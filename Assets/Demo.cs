using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    void Start()
    {
        //初始化GMCosole
        GMConsole.Instance.Startup();
        //屏幕最上方，连点4次，打开GM，也可以在GMCosole的UpdateKeyCode自己重新定义

        //自定义GM命令：例如
        //1.清除缓存命令
        GMConsole.Instance.RegisterCommandCallback("clear cache",
        (args) =>
        {
            PlayerPrefs.DeleteAll();
            return "clear cache";
        }, "清除缓存");
    }

}
