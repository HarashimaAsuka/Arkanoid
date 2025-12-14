using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    public int life = 1;
    public GameObject[] objectsToShowOnClear;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.name == "Ball"){

            this.life--;
    
            if(this.life <= 0){
                Destroy(this.gameObject);

                GameObject[] blockObject = GameObject.FindGameObjectsWithTag("Block");

                if(blockObject.Length <= 1){
                    Debug.Log("Clear");

                    Time.timeScale = 0.0f;

                    ShowObjectsOnClear();

                }
            }
        }
    }

    private void ShowObjectsOnClear(){
        foreach(GameObject obj in objectsToShowOnClear){
            obj.SetActive(true);
        }
    }
}