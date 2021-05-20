using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    public float speed;
    public Rigidbody rigidbody;
    public int Score;
    public Text wintext;
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float Horizontal = Input.GetAxis("Horizontal"); //A or D, Arrow keys
        float Vertical = Input.GetAxis("Vertical"); // W or S, Arrow Up and Down
        Vector3 direction = new Vector3(Horizontal, 0, Vertical);
        rigidbody.AddForce(direction * speed);
        if(Score>= 7)
        {
            wintext.text = "You win!";
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            Score = Score + 1;
            wintext.text = Score.ToString();
        }
    }
}
