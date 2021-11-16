using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // To create a variable:
    // private or public
    // data type (int, float, bool, string, etc)
    // every variable needs a name.
    // optional value can be assigned
    [SerializeField] // exposes a private var for Unity
    private float _speed = 3.5f;

    [SerializeField]
    private Transform _laser;

    [SerializeField]
    private float _fireRate = 0.5f;
    private float _nextFire = -1f;

    // Start is called before the first frame update
    void Start()
    {
        // take the current position, move to 0, 0, 0.
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        CalculateMovement();

        // if I hit the space bar
        // spawn a laser
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > _nextFire)
        {
            FireLaser();
        }
    }

    // Calculates player input.
    void CalculateMovement()
    {
        // Get the horizontal player controls.
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, vertical);
        transform.Translate(direction * _speed * Time.deltaTime);

        // move the player to the right.
        // new Vector3(1, 0, 0) x speed x framerate
        // transform.Translate(Vector3.right * horizontal * _speed * Time.deltaTime);
        // transform.Translate(Vector3.up * vertical * _speed * Time.deltaTime);


        // if the player position on Y is > 0
        // y position = 0
        // else if the player position on Y is < -3.8
        // y position = -3.8
        if (transform.position.y >= 0)
        {
            transform.position = new Vector3(transform.position.x, 0, 0);
        }
        else if (transform.position.y <= -3.8f)
        {
            transform.position = new Vector3(transform.position.x, -3.8f, 0);
        }

        // if the player position on X is > 11
        // x position = -11
        // else if the player position on X is < -11
        // x position = 11
        if (transform.position.x > 11f)
        {
            transform.position = new Vector3(-11f, transform.position.y, 0);
        }
        else if (transform.position.x < -11f)
        {
            transform.position = new Vector3(11f, transform.position.y, 0);
        }
    }

    // Fires a laser.
    void FireLaser()
    {
        Instantiate(_laser, transform.position, Quaternion.identity);
        _nextFire = Time.time + _fireRate;
    }
}
