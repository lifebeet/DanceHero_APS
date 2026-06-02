using UnityEngine;
using UnityEngine.Events;

public class SongManager : MonoBehaviour
{
[SerializeField]
private Animator characterAnimator;
[SerializeField]
private UnityEvent onSongStart;
[SerializeField]
private UnityEvent onSongSelected;
[SerializeField]
private UnityEvent onSongEnd;
private NotesManager notesManager;
private SoundData currentSongData;
public void PlaySong(SoundData songData)
    {
        characterAnimator.Play(songData.animationName);
        SoundManager.instance.PlayMusic(songData.songName);
        onSongStart?.Invoke();   
    }
    public void StopSong()
    {
        SoundManager.instance.StopMusic();
        onSongEnd?.Invoke();
    }
    public void StartSong()
    {
        characterAnimator.Play(currentSongData.animationName);
        SoundManager.instance.PlayMusic(currentSongData.songName);
        notesManager.StartNoteChart(currentSongData.noteChart, currentSongData.speed);
        onSongStart?.Invoke();
    }
}
