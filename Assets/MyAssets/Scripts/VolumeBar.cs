using UnityEngine;
using CriWare;
using UnityEngine.UI;
using R3;

public class VolumeBar : MonoBehaviour
{
    private CriAtomSource _atomSrc;

    [SerializeField]
    private Scrollbar _volumeBar;
    
    void Start() {
        /* CriAtomSource を取得 */
        _atomSrc = (CriAtomSource)GetComponent("CriAtomSource");
    }

    void Update()
    {
        _atomSrc.volume = _volumeBar.value;
    }
}
