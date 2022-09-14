using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAI : MonoBehaviour
{
    public Transform player;
    public Color color;

    void Start()
    {
        color = GetComponent<SpriteRenderer>().color;
    }

    void Update()
    {
        CheckState();
    }

    public void CheckState()
    {
        var pos = player.position;

        if(pos.x > transform.position.x)
        {
            color = Color.red;
        }
        else
        {
            color = Color.green;
        }
    }

}
