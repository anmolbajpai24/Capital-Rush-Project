using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSize : MonoBehaviour
{
    public GameObject parent;
    public GameObject child;
    
    public float xyComponent;
   

    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update

    private void Awake()
    {
      spriteRenderer = parent.GetComponent<SpriteRenderer>();
    }
    void Start()
    { 
        xyComponent = Random.RandomRange(0.5f, 2.5f);
        child.transform.localScale = new Vector3(xyComponent,xyComponent,1);
    }

    // Update is called once per frame
    void Update()
    {
        if (xyComponent > 1.6)
        {
            spriteRenderer.color = Color.red;
        }

       
    }

    private void OnApplicationQuit()
    {
        spriteRenderer.color = Color.yellow;
    }


}
