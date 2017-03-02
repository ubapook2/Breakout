using UnityEngine;
using System.Collections;

public class OneLife3 : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<BallController3>().GiveLife();
        GameObject.Destroy(this.gameObject);
    }

}
