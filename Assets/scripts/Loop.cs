using UnityEngine;

public class Loop : MonoBehaviour {

    public float startSpeed = 1.0f;
    public float dec = 0.1f;
    public Vector3 loopPos;
    public float maxPosX;

    private float speed;

    void Start () {
        Reset();
    }

	void Update () {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        
        if(transform.position.x >= maxPosX)
        {
            transform.position = new Vector3(loopPos.x, transform.position.y, 0);
        }
    }

    public void Stop () {
        speed = 0;
    }

    public void Reset() {
        speed = startSpeed;
    }
}