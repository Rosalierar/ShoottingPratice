using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Transform shotPoint;
    public GameObject poderPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Shot();
        }
    }
    void Shot()
    {
        Instantiate(poderPrefab, shotPoint.position, shotPoint.rotation);
    }
}
