using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafDespawn : MonoBehaviour
{
    public float lifeTime = 1.5f;
    void Update() {
        if(lifeTime > 0){
            lifeTime -= Time.deltaTime;
        }else{
            Destruction();
        }
    }

    private void Destruction()  {
        Destroy(this.gameObject);
    }

}
