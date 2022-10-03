using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Use : MonoBehaviour
{
    bool can_use = false;
    public GameObject Usable;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player") can_use = true; 
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player") can_use = false;
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.E) && can_use)
         Destroy(gameObject);
    }
}
