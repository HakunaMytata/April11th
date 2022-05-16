using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MathUtil;

public class NPCController : MonoBehaviour
{
    GameObject player;
    public float speed = 2f;
    private Transform myTransform;

   


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }
    void Awake()
    {
        myTransform = transform;
    }
    // Update is called once per frame
    void Update()
    {
        if(Util.CanSeeObj(player, gameObject, 0.9f))
        {
            Debug.Log("I can see the player!");
        }

        myTransform.position -= myTransform.forward * speed * Time.deltaTime;
    }
}
