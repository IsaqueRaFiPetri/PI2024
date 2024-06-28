using UnityEngine;
using UnityEngine.UI;

public class PoliticsPoints : MonoBehaviour
{
    public static PoliticsPoints instance;
    static int ppAmount;
    public static int ppMax; 
    public Image ppBar;
    public GameObject conclusionPainel;

    void Start()
    {
        ppMax = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GainPoints(int politcPoints)
    {
        ppAmount = politcPoints;
        SetPP();
        if (ppAmount >= ppMax)
        {
            conclusionPainel.SetActive(true);
        }
    }
    public void SetPP()
    {
        ppBar.fillAmount = (float)PoliticsPoints.ppAmount / (float)PoliticsPoints.ppMax;
    }

    public void AddPP(int ppGained)
    {
        ppAmount = ppGained;
        ppGained += 1;
        SetPP();
    }
}
//pp = Political Points