using Fungus;
using UnityEngine;

public class TestChat : MonoBehaviour
{
    [SerializeField] private Flowchart flowChart;
    void Start()
    {
        flowChart.SendFungusMessage("StartChat");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
