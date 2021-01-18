using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AppLauncherPlugin;

public class OpenPersonalApp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MobileAppLauncher(string appID)
    {
        AppLauncher.LaunchApp(""+ appID, gameObject.name);
        print("Launch: " + appID);
    }
}
