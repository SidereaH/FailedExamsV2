using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    // Start is called before the first frame update
    TextMeshProUGUI text;
    void Start()
    {
        //score = GameObject.FindGameObjectWithTag("SceneManger").gameObject.transform.GetComponent<ScoreManager>();
        try{
            text = gameObject.transform.GetChild(0).transform.GetComponent<TextMeshProUGUI>();
        }
        catch{
            Debug.Log("out of dauns");
        }
        
        //text.text = score.gold.ToString();
    }

    public void UpdateCoin(int coins){
        text.text = coins.ToString();
    }

}
