using UnityEngine;
using System.Collections;

public class OneLife2 : MonoBehaviour
{
        public void OnCollisionEnter2D(Collision2D collision)
        {
            FindObjectOfType<BallController2>().GiveLife();
            GameObject.Destroy(this.gameObject);
        }
    
}
