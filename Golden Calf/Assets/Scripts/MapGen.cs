using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGen : MonoBehaviour
{
    [SerializeField] Hex hexPrefab;
    [SerializeField] int minNumLine;
    [SerializeField] float height;
    [SerializeField] float xPadding;
    [SerializeField] float yPadding;
    float initialX;
    float initialY;
    // Start is called before the first frame update
    void Start()
    {
        Generate();
    }


    void Generate()
    {
        initialY = transform.position.y;
        initialX = transform.position.x;

        for (int i = 0;i<height/2;i++)
        {
            for(int j = 0;j<minNumLine;j++)
            {
                Instantiate(hexPrefab,new Vector3(initialX+j*xPadding,transform.position.y,initialY - yPadding*i),transform.rotation);
            }
            initialX -= xPadding/2;
            minNumLine++;
        }

    }
}
