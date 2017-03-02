using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

    public GameObject prize;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<BallController>().BrickSmashed();
        GameObject.Destroy(this.gameObject);
        //if (prize != null)
        //{
       //     Instantiate(prize, transform.position, Quaternion.identity);
        //}
   
    }


}
