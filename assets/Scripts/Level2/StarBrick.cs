using UnityEngine;
using System.Collections;

public class StarBrick : MonoBehaviour
{

        public void OnCollisionEnter2D(Collision2D collision)
        {
            FindObjectOfType<BallController2>().StarBrickSmashed();
            GameObject.Destroy(this.gameObject);
        }
   
}
