using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrickCloner : MonoBehaviour {
    public GameObject brick;
    public Text ingresoCant;
    public float xPosicion = 0;


    private void Start()
    {
     
    }


    public void brickCloner()
    {
        
        GameObject clone;
       
        
        for (int i = 0; i > float.Parse(ingresoCant.text); i++)
        {
            clone = Instantiate(brick);
            clone.transform.position += new Vector3(xPosicion, 0, 0);
            xPosicion = xPosicion + 1.1f;
            Destroy(clone,2);
        }

        
    }
	
      

	
	
}
//no me anda, checkear prox clase

/*
 * 
*/
