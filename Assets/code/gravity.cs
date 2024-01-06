using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class gravity : MonoBehaviour
{
    public Transform player;
    public Rigidbody2D playerbod;
    public float intensity;
    private float disttoplayer;
    private Vector2 pullforce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float diff = Vector2.Distance(player.position,transform.position);
        disttoplayer = math.max(1, diff);
        pullforce = (transform.position - player.position).normalized /disttoplayer*intensity;
        playerbod.AddForce(pullforce);
    }
}
