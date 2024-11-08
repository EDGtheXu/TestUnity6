using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    float speed = 0.1f;
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * 0.1F;
        float y = Input.GetAxis("Vertical") * 0.1F;
        transform.Translate(x, 0, y);

 


    }
}
