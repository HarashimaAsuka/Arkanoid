using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed = 20.0f;

    public Vector3 shotDirection = new Vector3(0.5f,0.5f,0);

    public float shotSpeed = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rigidbody = this.GetComponent<Rigidbody>();

        if(rigidbody == null)
        return; //Rigidbodyがなかった場合処理の終了

        if (Input.GetKey(KeyCode.A)){
            rigidbody.velocity = new Vector3(-this.speed,0,0);
        }

        else if(Input.GetKey(KeyCode.D)){
            rigidbody.velocity = new Vector3(this.speed,0,0);
        }

        else{
            rigidbody.velocity = new Vector3(0,0,0);
        }

        if(Input.GetMouseButtonDown(0)){
            Transform childBall = this.transform.Find("Ball");
            if(childBall != null){
                childBall.transform.parent = null;

                Rigidbody ballRigidbody = childBall.GetComponent<Rigidbody>();

                ballRigidbody.isKinematic = false;

                ballRigidbody.velocity = this.shotDirection * this.shotSpeed;
            }
        }
    }
}
