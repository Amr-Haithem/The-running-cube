using UnityEngine;
using UnityEngine.UI;


public class scores : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform player;
    public Text uitext;

    // Update is called once per frame
    
    
    void Update()
    {
        float num;
        num = player.position.z * -1;
        uitext.text=num.ToString("0");
        
    }
}
