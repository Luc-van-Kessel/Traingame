using UnityEngine;

public class TurnUI : MonoBehaviour, ITurnUI
{
    public void disableUI()
    {
        gameObject.SetActive(false);
    }

   
}
