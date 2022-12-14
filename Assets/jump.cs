using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    bool is_ground = false;
    Rigidbody gg;
    public float force = 6;
    // Start is called before the first frame update
    void Start()
    {
        gg = GetComponent<Rigidbody>();
    }

    private void OnTriggerStay(Collider col)
    {
        if (col.tag == "ground") is_ground = true; 
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.tag == "ground") is_ground = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && is_ground)
            gg.AddForce(Vector2.up * force, ForceMode.Impulse);
    }
}
