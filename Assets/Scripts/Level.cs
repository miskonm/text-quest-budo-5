using UnityEngine;

public class Level : MonoBehaviour
{
    [TextArea(4, 12)]
    public string Description;
    
    [TextArea(4, 6)]
    public string Answers;

    public Level[] NextLevels;
}