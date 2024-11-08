using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject obj = GameObject.Find("Player");
        if (obj != null)
        {
            target = obj;
            this.transform.SetParent(target.transform);
        }
    }
    GameObject target;
    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            this.transform.LookAt(target.transform);

            float x = UnityEngine.Input.mousePositionDelta.x;
            float y = UnityEngine.Input.mousePositionDelta.y;


            target.transform.RotateAround(target.transform.position, new Vector3(0, 1, 0), x*0.5f);

        }
    }
}
