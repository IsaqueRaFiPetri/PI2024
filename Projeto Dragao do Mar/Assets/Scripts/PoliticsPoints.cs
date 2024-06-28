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
        if (ppAmount >= ppMax)
        {
            conclusionPainel.SetActive(true);
            PlayerStats.instance.SetUIingMode();
        }
    }

    public void GainPoints(int politcPoints)
    {
        ppAmount = politcPoints;
        SetPP();
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