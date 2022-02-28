using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeteciBrojevi : MonoBehaviour
{
    public float brzinaBroja;
    public int brojRanjen;
    public Text broj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        broj.text = "" + brojRanjen;
        transform.position = new Vector3(transform.position.x,
            transform.position.y + brzinaBroja * Time.deltaTime, transform.position.z);

    }
}
