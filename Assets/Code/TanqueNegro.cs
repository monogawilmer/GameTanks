using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class TanqueNegro : MonoBehaviour
{
    [Range(1f,10f)]
    public float velocidad;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Input.GetButton("Fire1")
        // Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.Translate(-0.05f , 0, 0);
            transform.Translate(Vector2.left * velocidad * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * velocidad * Time.deltaTime);
        }
    }
}
