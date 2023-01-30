using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SaveController : MonoBehaviour
{
    private int m_colecionavel;

    // Start is called before the first frame update
    void Start()
    {
        SetText();
        Debug.Log("Passou Pelo Start");
    }

    public void SetText()
    {

        m_colecionavel = PlayerPrefs.GetInt("Colecionavel", 0);
    
    }
    // Update is called once per frame
    void Update()

    {
     
       

       

    }


   

}