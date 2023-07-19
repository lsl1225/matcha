# Cafe.Matcha

## About

Matcha (抹茶) is an ACT plugin that provides notifications for in-game events such as F.A.T.E.s, duty notifications and zone changing. It also has functions like market board querying, gearsets comparison, treasure map locating, and cactpot predictions when it's used together with [Matcha Overlay](https://github.com/zhyupe/matcha-overlay). 

The name of Matcha is from Match'a, with the project initially focusing on matching events.

At this time, Matcha only provides up-to-date support for the CN server and only available in Chinese. It should be working in the Global server with proper opcodes filled, and i18n related contributions are welcomed.



## Building from source

### Download dependencies

1. Please download the latest Zip file from <https://github.com/EQAditu/AdvancedCombatTracker/releases/>

1. Extract the `Advanced Combat Tracker.exe` to `matcha/thirdparty/ACT/`

1. Please download the latest SDK Zip file from <https://github.com/ravahn/FFXIV_ACT_Plugin/> (make sure the file says SDK in its name)

1. Extract the `SDK folder` as well as the `FFXIV_ACT_Plugin.dll` to `matcha/thirdparty/FFXIV_ACT_Plugin/`

1. Make sure that you have installed Windows SDK 19041 in the default install location.

   **File path:**  `C:\Program Files (x86)\Windows Kits\10\References\10.0.19041.0\Windows.Foundation.UniversalApiContract\10.0.0.0\Windows.Foundation.UniversalApiContract.winmd`

1. Continue with **Steps to build**

The folder should look something like this:

```plaintext
thirdparty
|- ACT
|  |- Advanced Combat Tracker.exe
|- FFXIV_ACT_Plugin
|  |- SDK
|  |  |- FFXIV_ACT_Plugin.Common.dll
|  |  |- FFXIV_ACT_Plugin.Config.dll
|  |  |- FFXIV_ACT_Plugin.LogFile.dll
|  |  |- FFXIV_ACT_Plugin.Memory.dll
|  |  |- FFXIV_ACT_Plugin.Network.dll
|  |  |- FFXIV_ACT_Plugin.Overlay.dll
|  |  |- FFXIV_ACT_Plugin.Parse.dll
|  |  |- FFXIV_ACT_Plugin.Resource.dll
|  |- FFXIV_ACT_Plugin.dll
```

### Steps to build

1. Open the solution in Visual Studio (tested with Visual Studio 2022).
1. Build for "Release".
1. The plugin will be built as **bin/Cafe.Matcha-'Version'-Release.zip**.
1. Extract the Zip file and copy **all of them** to `%AppData%\Advanced Combat Tracker\Plugins`
1. Add the built plugin directly as an ACT plugin.  In the ACT -> Plugins -> Plugin Listing tab, click the `Browse` button and find **Cafe.Matcha\Cafe.Matcha.dll** at default ACT plugins folder.  Then click `Add/Enable Plugin`.

