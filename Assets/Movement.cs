using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 10;
    public float turningSpeed = 60;
    public static float vertical, horizontal;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator.GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
        transform.Translate(0, 0, horizontal);
        
    }
}
