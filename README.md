# GM Cosole

# 1.初始化
```
GMCosole.Instance.StartUp();
```

# 2.打开
```
屏幕最上方，快速连击4次，可以打开和关闭
```

# 3.注册新的GM命令
```
GMConsole.Instance.RegisterCommandCallback("clear cache",(args) =>{
	PlayerPrefs.DeleteAll();
	return "clear cache";
}, "清除缓存");
            
```

# 4.关闭GM
```
close命令或者屏幕上方再连点4次
```

# 5.效果图

![gm_console](https://github.com/passiony/GM/blob/master/preview_gm_console.png)