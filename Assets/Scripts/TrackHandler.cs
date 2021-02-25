using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackHandler : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0f;
    [SerializeField] GameObject trackPrefab;
    private float distanceOfDeletion = -200f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate( - Vector3.forward * Time.deltaTime * moveSpeed);
        if(gameObject.transform.position.z <= distanceOfDeletion)
        {
            Destroy(gameObject.transform.GetChild(0).gameObject);
            distanceOfDeletion -= 200;
            GameObject temp =  Instantiate(trackPrefab, Vector3.zero, Quaternion.identity);
            temp.transform.position = new Vector3(0, 0, gameObject.transform.GetChild(gameObject.transform.childCount - 1).transform.position.z +200f);
            temp.transform.parent = gameObject.transform;
        }
    }
}
