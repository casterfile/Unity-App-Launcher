using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AppLauncherPlugin;

public class OpenPersonalApp : MonoBehaviour
{

    public void MobileAppLauncher(string appID)
    {
        AppLauncher.LaunchApp(""+ appID, gameObject.name);
        print("Launch: " + appID);
    }
}
