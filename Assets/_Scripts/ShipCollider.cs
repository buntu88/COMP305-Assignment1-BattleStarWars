using UnityEngine;
using System.Collections;

public class ShipCollider : MonoBehaviour {

    // PRIVATE INSTANCE VARIABLES
    private AudioSource[] _audioSources;
    private AudioSource _enemySound;
    private AudioSource _planetSound;
    // PUBLIC INSTANCE VARIABLES
    public GameController gameController;

    // Use this for initialization
    void Start()
    {
        // Initialize the audioSources array
        this._audioSources = gameObject.GetComponents<AudioSource>();
        this._enemySound = this._audioSources[1];
        this._planetSound = this._audioSources[2];
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("Planet"))
        {

                this._planetSound.Play();
                this.gameController.ScoreValue += 100;

        }
        if (other.gameObject.CompareTag("Enemy"))
        {

                this._enemySound.Play();
                this.gameController.LivesValue -= 1;
        }
        
    }

}
