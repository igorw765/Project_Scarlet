using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour
{

    GameObject Tree;
    GameObject Seed;
    private bool value;

    void Start(){
        GrowTree();
        DeGrowTree();
        value = false;
    }
    void Update(){
        if(transform.position.y >= 1.4f)
            value = true;
        

        if(isHiden()){
            Application.Quit();
            Debug.Log("quiting");
        }
    }

    public void GrowTree(){
        transform.LeanMoveLocal(new Vector2(-0.01983261f ,1.54f), 60).setEaseOutQuart().delay = 10f;
    }
    public void DeGrowTree(){
        transform.LeanMoveLocal(new Vector2(-0.01983261f ,-5.82f), 60).setEaseOutQuart().delay = 75f;
    }

    private bool isHiden(){
        if(transform.position.y <= -5.8f && value)
            return true;
        else
            return false;
    }
    
        
    
}
