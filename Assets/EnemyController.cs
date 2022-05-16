using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 2f;
    private Transform myTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Awake()
    {
        myTransform = transform;
    }
    // Update is called once per frame
    void Update()
    {
        myTransform.position -= myTransform.forward * speed * Time.deltaTime;
    }
}
