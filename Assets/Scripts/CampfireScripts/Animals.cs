using System.Runtime.CompilerServices;
using UnityEditorInternal;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Animals : MonoBehaviour
{
    [Header("움직이는 속도")]
    public float speed = 1f;

    private float[] yPos = {4.4f,-3f,3.2f,3.25f,-2f,-2f,0.5f,0.5f};//위,아,오위,왼위,오아,왼아,오
    private float[] xPos = {0f,0f,4.75f,-4.6f,4.75f,-4.75f,6.7f,-6.7f};
    private Vector2 target;



    void Start()
    {
        int randomCount = PlayerPrefs.GetInt("RandomCount");
        target = new Vector2(xPos[randomCount], yPos[randomCount]);
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }

}
