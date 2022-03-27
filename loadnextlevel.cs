using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadnextlevel : MonoBehaviour
{
    public string sceneName;
    void Start()
    {
        
    }

    // Update is called once per frame
    [System.Obsolete]
    void OnTriggerEnter(Collider user)
    {
        if (user.tag == "Player")
        {
            Application.LoadLevel(sceneName);
        }
    }
}
