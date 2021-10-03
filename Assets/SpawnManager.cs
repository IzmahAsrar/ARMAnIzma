using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    public GameObject PacmanController;
    int x = 0;
    public float TimeaLimit;
    public float h, s;
    public int currentlevel=1;
    void Start()
    {
        if (currentlevel == 1)
        {
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (s > 0)
        {
            s -= 1 * Time.deltaTime;
            // 
        }
        else
        {
            if (h > 0)
            {
                h--;
                s = 60;
            }
           
        }
        if (h == 0 && s == 0)
        {
            print("Gameover");
        }
        //if (h > 0)
        //{
        //    s = 60;
            
        //}
        if (GameObject.FindWithTag("SpawnGame") && x == 0)
        {
            PacmanController.GetComponent<PacmanController>().enabled = true;
            Instantiate(prefab, GameObject.FindWithTag("SpawnGame").transform.position, GameObject.FindWithTag("SpawnGame").transform.rotation);
            x = 1;
        }
    }
}
