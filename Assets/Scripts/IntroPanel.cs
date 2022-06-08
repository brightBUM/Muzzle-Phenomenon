using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(fileName = "IntroPanel")]
public class IntroPanel : ScriptableObject
{
    public Sprite panelImage;
    [TextArea]
    public string panelDialogue;
    
}
