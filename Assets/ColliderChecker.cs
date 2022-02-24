using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderChecker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisonEnter2D(Collider2D collider)
    {
        Debug.Log("Collision");
        if(collider.transform.tag == "color change")
        {
            Debug.Log("collided");
            this.transform.parent.gameObject.GetComponent<PlayerColorManager>().ChangeColor();
        }
    }
}
