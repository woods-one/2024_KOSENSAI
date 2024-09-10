using UnityEngine;
using CriWare;

public class CuePlay : MonoBehaviour
{
    private CriAtomSource _atomSrc;
    
    private bool _playing = false;

    void Start() {
        /* CriAtomSource を取得 */
        _atomSrc = (CriAtomSource)GetComponent("CriAtomSource");
    }

    public void PlaySound() {
        if (_atomSrc != null) {
            if (_playing == false)
            {
                _atomSrc.Play();
                _playing = true;
            }
            else
            {
                _atomSrc.Stop();
                _playing = false;
            }
        }
    }

    public void PlayAndStopSound() {
        if (_atomSrc != null) {
            CriAtomSource.Status status = _atomSrc.status;
            if ((status == CriAtomSource.Status.Stop) || (status == CriAtomSource.Status.PlayEnd)) {
                _atomSrc.Play();
            } else {
                _atomSrc.Stop();
            }
        }
    }
}
