using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animscript : MonoBehaviour
{
    // Start is called before the first frame update
    public Material Water;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Water.mainTextureOffset += new Vector2(0.5f*Time.deltaTime, 0);
    }
}
