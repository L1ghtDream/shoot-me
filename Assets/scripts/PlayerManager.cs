using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour{

    private static double MAX_X = 8.89;
    private static double MAX_Y = 5;
    private static double AGENT_WIDTH = 0.34;
    private static double AGENT_HEIGHT = 0.74;

    private void Start(){
        
    }

    private void Update(){
        
    }
    
    private void generateAgents(int count){
        int x = Random.Range((int) (-MAX_X * 100), (int) MAX_X * 100);
    }
}
