using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public Transform Head;
    public float spawnDistance;
    public GameObject menu;

    void FixedUpdate()
    {
        if (watchEnable.UISetActive)
        {
            Watch();
        }
        else
        {
            menu.transform.position = menu.transform.position = new Vector3(Head.forward.x, -10, Head.forward.z).normalized * spawnDistance;
            //When not enabled, don't disable the watch but move it down so it is not visible
        }
       
    }

    public void Watch()
    {

            //menu.SetActive(!menu.activeSelf);

            menu.transform.position = Head.position + new Vector3(Head.forward.x, 0, Head.forward.z).normalized * spawnDistance;
            menu.transform.LookAt(new Vector3(Head.position.x, menu.transform.position.y, Head.position.z));
            menu.transform.forward *= -1;

        //The menu looks at the inserted gameobject
    }
}
