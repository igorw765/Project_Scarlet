using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafSpawner : MonoBehaviour
{
    
    public Transform SpawnPos;
    public GameObject leaf;
    

    void Start(){
        leaf.transform.localScale = Vector2.zero;
    }

    void Update(){
       
        if(isGrowned())
            Renderer();
    }

    private void Renderer(){
            var position = new Vector3(Random.Range(-10f, 10f), 
            Random.Range(6f, 8f), 0f);
            SpawnPos.transform.Rotate(Random.Range(0f, 360f),0,0,0);
            SpawnPos.position = position;
            Instantiate(leaf, SpawnPos.position, SpawnPos.rotation);
            AppearLeaf();
    }


    private void AppearLeaf(){
        leaf.transform.LeanScale(Vector2.one, 1f);
    }

    private bool isGrowned(){
        if(transform.position.y >= 1.4f)
            return true;
        else
            return false;
    }

    
}