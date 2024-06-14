using UnityEngine;
using System.Linq;
using Klak.Ndi;

public sealed class AutoConnect : MonoBehaviour
{
    void Update()
    {
        var sources = NdiFinder.sourceNames.ToArray();
        if (sources.Length > 0)
        {
            Debug.Log("NDI connection to " + sources[0]);
            GetComponent<NdiReceiver>().ndiName = sources[0];
            enabled = false;
        }
    }
}
