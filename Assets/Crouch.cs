using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl) | Input.GetKeyDown(KeyCode.C))
            gameObject.transform.localScale -= new Vector3(0, 0.5f, 0);

        if (Input.GetKeyUp(KeyCode.LeftControl) | Input.GetKeyUp(KeyCode.C))
            gameObject.transform.localScale += new Vector3(0, 0.5f, 0);    
    }
}
