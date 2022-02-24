using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGameplayManager : MonoBehaviour
{
    public GameObject particleSys;
    public int score = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckColorWithHurdle(Collider2D col)
    {
        var a = col.gameObject.GetComponent<SpriteRenderer>().color;
        var b = this.gameObject.GetComponentInChildren<SpriteRenderer>().color;
        Debug.Log(b);
        Debug.Log(a);
        if (a == b)
        {
            Debug.Log("Passed");
        }
        else
        {
            Debug.Log("NOt PAssed");
            particleSys.transform.position = this.gameObject.GetComponentInChildren<SpriteRenderer>().gameObject.transform.position;
            particleSys.SetActive(true);
            particleSys.GetComponent<ParticleSystem>().Play();
            Destroy(this.gameObject);
        }
    }

    public void Score()
    {
        score++;
    }
}
