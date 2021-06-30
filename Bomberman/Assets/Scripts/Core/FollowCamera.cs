using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private Transform player;
    Vector3 startpos;
    void Start()
    {
        startpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void LateUpdate()
    {
        if (player != null)
        {
            transform.position = new Vector3(player.position.x, 0, player.position.z) + startpos;
        }
    }
}
