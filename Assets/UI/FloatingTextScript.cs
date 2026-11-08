using UnityEngine;

public class FloatingTextScript : MonoBehaviour
{
    [SerializeField] private Transform mainCam;
    [SerializeField] private Transform unit;
    [SerializeField] private Transform worldSpaceCanvas;

    public Vector3 offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.SetParent(worldSpaceCanvas);
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.LookRotation(transform.position - mainCam.transform.position);
        transform.position = unit.position + offset;
    }
}
