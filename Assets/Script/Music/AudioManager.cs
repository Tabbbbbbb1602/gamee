using UnityEngine;
using UnityEngine.Audio;
using System;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    public static AudioManager instance;

    private float MusicVolume = 0.5f;
    private float SoundVolume = 0.5f;
    public Slider volumeSliderMusic;
    public Slider VolumeSliderSound;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
;        }
    }

    private void Start()
    {
        MusicVolume = PlayerPrefs.GetFloat(PrefConst.MUSIC);
        volumeSliderMusic.value = MusicVolume;
    }

    private void Update()
    {
        PlayerPrefs.SetFloat(PrefConst.MUSIC, MusicVolume);
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null) return;
        s.source.Play();
    }

    public void UpdateVolumeMusic(float volume)
    {
        gameObject.GetComponent<AudioSource>().volume = MusicVolume;
        MusicVolume = volume;
    }

    public void MusicReset()
    {
        PlayerPrefs.DeleteKey("music");
        //gameObject.AddComponent<AudioSource>().volume = 1;
        volumeSliderMusic.value = 1;
    }

    public void MuteMusic()
    {

    }
}
