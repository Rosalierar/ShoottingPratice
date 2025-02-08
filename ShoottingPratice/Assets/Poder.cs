using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poder : MonoBehaviour
{
    public float speed = 20f;

    public Rigidbody2D rbPoder;
    // Start is called before the first frame update
    void Start()
    {
        rbPoder.velocity = transform.right * speed;
    }

}
