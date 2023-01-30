
using UnityEngine;
using UnityEngine.AI;

public class TouchPad : MonoBehaviour
{
    private Vector3 position;
    private float width;
    private float height;

    void Start()
    {

    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Move the cube if the screen has the finger moving.
            if (touch.phase == TouchPhase.Moved)
            {
                Vector2 pos = touch.position;
                pos.x = (pos.x - width) / width;
                pos.y = (pos.y - height) / height;
                position = new Vector3(-pos.x, pos.y, 0.0f);

                // Position the cube.
                transform.position = position;
            }


            // if (Input.touches.Length > 0 && input.) {



            //}
            /////if (Input.GetMouseButtonDown(0))
            //{
            //    RaycastHit hit;

            //    if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            //    {
            //        agent.position = hit.point;
            //    }
            //}

        }
    }
}