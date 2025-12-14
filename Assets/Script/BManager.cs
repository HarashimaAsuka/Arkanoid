using UnityEngine; 
using System.Collections; 

public class BallManager : MonoBehaviour { 

    private Vector3 initialPosition; 

    void Start (){ 
        this.initialPosition = this.transform.localPosition; 
    } 

    void Update (){ 
    } 

    void Initialize(){
        GameObject paddle = GameObject.Find("Paddle");

        if(paddle){

            this.transform.parent = paddle.transform;
            this.transform.localPosition = this.initialPosition;

            Rigidbody rigidbody = this.GetComponent<Rigidbody>();
 
            if(rigidbody){
            rigidbody.velocity = new Vector3(0, 0, 0);
            rigidbody.isKinematic = true;
            }
        }
    } 

    private void OnCollisionEnter(Collision collision){

        if(collision.gameObject.name == "UnderBlock"){

            this.Initialize();
        }
    } 
}
