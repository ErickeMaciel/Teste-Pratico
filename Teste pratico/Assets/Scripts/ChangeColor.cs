using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

    public Material objMat;
    public Renderer[] objMatChilds;
    
  
	// Use this for initialization
	void Start ()
    {
        // Buscar o material existente do objeto
        objMat = GetComponent<Renderer>().material;
        objMat.color = Color.black;

        // Buscar o componente renderer de todos os objetos filhos
        objMatChilds = GetComponentsInChildren<Renderer>();

     
        // Acessar o material dos objetos filhos e substituir pelo mesmo do pai
        foreach(Renderer rend in objMatChilds)
        {
            var mats = new Material[rend.materials.Length];
            for(var j = 0; j < rend.materials.Length; j++)
            {
                mats[j] = objMat;
            }
            rend.materials = mats;
          
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    // Funcao para trocar a cor do objeto
    public void ObjColor()
    {
        if(objMat.color == Color.black)
        {
            objMat.color = Color.white;
        }
        else if (objMat.color == Color.white)
        {
            objMat.color = Color.red;
        }
        else if (objMat.color == Color.red)
        {
            objMat.color = Color.blue;
        }
        else if (objMat.color == Color.blue)
        {
            objMat.color = Color.black;
        }



    }
}
