using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColorManager : MonoBehaviour
{
    public SpriteRenderer playerSprite; 
    
    // Start is called before the first frame update
    void Start()
    {
        playerSprite.color = new Color(255, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeColor()
    {
        var a = Random.Range(0,this.gameObject.GetComponent<ColorManager>().colors.Length);
        var colorName = this.gameObject.GetComponent<ColorManager>().colors[a];
        Debug.Log(a);
    }
}
