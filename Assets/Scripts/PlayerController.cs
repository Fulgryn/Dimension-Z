using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("MoveRight"))
        {
            gameObject.transform.Translate(Vector3.right * moveSpeed *Time.deltaTime);
        }else if (Input.GetButton("MoveLeft"))
        {
            gameObject.transform.Translate(- Vector3.right * moveSpeed * Time.deltaTime);
        }
    }
}
