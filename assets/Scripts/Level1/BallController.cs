using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BallController : MonoBehaviour
{

    Vector2 startPosition;
    new Rigidbody2D rigidbody2D;
    public float maxSpeed = 20;

    public int lives = 7; // lives variable and count
    public GameObject outSign;

    public int points = 0; // variable for keeping track of points generated
    public int pointsneeded;

    public Text scoreText;
    public Text livesText;


    //public int bricksLeft; // bricks smashed/destroyed variable and count
    public GameObject winSign;

    // Use this for initialization
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        startPosition = this.transform.position;
        //bricksLeft = (FindObjectsOfType<Brick>().Length) + (FindObjectsOfType<SuperBrick>().Length);


        scoreText.text = points.ToString();
        livesText.text = lives.ToString();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FixedUpdate()
    {
        rigidbody2D.velocity = Vector2.ClampMagnitude(rigidbody2D.velocity, maxSpeed);
        // Debug.Log (rigidbody2D.velocity.magnitude);
    }

    public void Die()
    {
        lives--;
        livesText.text = lives.ToString();

        // Debug.Log(lives); taken out for testing win sign
        this.transform.position = startPosition;
        rigidbody2D.velocity = new Vector2(0, -1);

        if (lives == 0)
        {
            outSign.SetActive(true);
            Time.timeScale = 0;
        }

    }

    public void SuperBrickSmashed()
    {
        points += 2;
        scoreText.text = points.ToString();
        pointsneeded = 12;
        if (points == pointsneeded)
        {
            //winSign.SetActive(true);
            FindObjectOfType<UIManagerScript>().StartGame();
            Application.LoadLevel("Level2");
            //Time.timeScale = 0;
        }

        //bricksLeft--;
    }

    public void BrickSmashed()
    {

        points++;
        scoreText.text = points.ToString();
        pointsneeded = 12;
        

        //bricksLeft--;
        //Debug.Log(bricksLeft);

        // if (bricksLeft == 0)
       if (points == pointsneeded)
       {
           //winSign.SetActive(true);
         FindObjectOfType<UIManagerScript>().StartGame();
         Application.LoadLevel("Level2");
            //Time.timeScale = 0;
       }

    }


    public void GiveLife()
    {
        lives++;
        livesText.text = lives.ToString();
    }


}