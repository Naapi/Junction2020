using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemy_score : MonoBehaviour
{
     Text txt;
     private int currentscore=0;
 
     // Use this for initialization
     void Start () {
         txt = gameObject.GetComponent<Text>(); 
         txt.text="Score : " + currentscore;
     }
     
     // Update is called once per frame
     void Update () {
         txt.text="Enemy Score : " + currentscore;  
         currentscore = PlayerPrefs.GetInt("TOTALSCORE"); 
         PlayerPrefs.SetInt("SHOWSTARTSCORE",currentscore); 
     }
}
