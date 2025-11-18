using UnityEngine;

public class UnderWorldCameraBehavior : MonoBehaviour
{
    public float scale = .01f;
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveCamera(Transform cameraTransform)
    {
        transform.position = cameraTransform.position * scale + new Vector3(0, -100, 0);
        transform.rotation = cameraTransform.rotation;
    }
}
