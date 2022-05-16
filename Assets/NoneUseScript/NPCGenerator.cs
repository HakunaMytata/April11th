using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCGenerator : MonoBehaviour
{
    
    public GameObject npcPrefab;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 2) // generate ball 
        {
            timer = 0;
            GameObject newNPC = Instantiate(npcPrefab);
            newNPC.transform.position = new Vector3(
                                                transform.position.x + 10f,
                                                transform.position.y - 1f,
                                                0f

                );



        }
    }
}
