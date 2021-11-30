using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float _speed = 4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // move down at 4m/s
        // if bottom of screen
        // respawn at the top
            // BONUS: random X position
        
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
        if (transform.position.y < -6f)
        {
            float posX = Random.Range(-9f, 9f);
            transform.position = new Vector3(posX, 7, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Testing:
        Debug.Log($"Hit: {other.name}");

        // if other is player
        // damage the player
        // destroy us
        if (other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                player.Damage();
            }
            Destroy(gameObject);
        }

        // if other is laser
        // destroy laser
        // destroy us
        if (other.tag == "Laser")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
