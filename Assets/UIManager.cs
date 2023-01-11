using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public Transform Head;
    public float spawnDistance;
    public GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (watchEnable.UISetActive)
        {
            Watch();
        }
        else
        {
            menu.transform.position = menu.transform.position = new Vector3(Head.forward.x, -10, Head.forward.z).normalized * spawnDistance;
        }
       
    }

    public void Watch()
    {

            //menu.SetActive(!menu.activeSelf);

            menu.transform.position = Head.position + new Vector3(Head.forward.x, 0, Head.forward.z).normalized * spawnDistance;
            menu.transform.LookAt(new Vector3(Head.position.x, menu.transform.position.y, Head.position.z));
            menu.transform.forward *= -1;
    }
}
