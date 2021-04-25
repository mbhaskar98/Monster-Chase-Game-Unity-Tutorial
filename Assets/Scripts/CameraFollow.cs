using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform player;

    private Vector3 tempPos;

    private string PLAYER_TAG = "Player";
    // Start is called before the first frame update

    private float minX, maxX;
    void Start()
    {
        player = GameObject.FindWithTag(PLAYER_TAG).transform;   
        minX = (float)-61;
        maxX = (float)61;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        tempPos = transform.position;
        tempPos.x = player.position.x;

        if(tempPos.x < minX) {
            tempPos.x = minX;
        }
        if(tempPos.x > maxX){
            tempPos.x = maxX;
        }
        
        transform.position = tempPos;
        
    }
}
