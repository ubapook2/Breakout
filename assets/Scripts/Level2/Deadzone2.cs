using UnityEngine;
using System.Collections;

public class Deadzone2 : MonoBehaviour {

    public void OnCollisionEnter2D(Collision2D collision)
    {
        // Debug.Log (collision.gameObject);	
        // FindObjectOfType<BallController> ().Die ();  previous way to die
        var ball = collision.gameObject.GetComponent<BallController2>();
        if (ball != null)
        {
            ball.Die();
        }
    }
}
