using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudManager : MonoSingleton<HudManager>
{
    [SerializeField] Text remainingBombs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        remainingBombs.text = "Bombs " + PlayerController.bombCount.ToString();
    }
}
