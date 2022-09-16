using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_sound_effect : MonoBehaviour
{
    public float audiosound = 100;

    public List<AudioSource> AudioSources = new List<AudioSource>();
    Dictionary<string, AudioClip> Audios = new Dictionary<string, AudioClip>();

    [SerializeField] List<string> Audioname = new List<string>();
    [SerializeField] List<AudioClip> Audioclip = new List<AudioClip>();

    [SerializeField] AudioSource audio3D;
    public List<AudioSource> audio3dpool = new List<AudioSource>();
 
    void Awake()
    {
        for(int i = 0; i < Audioname.Count; i++)
        {
            Audios.Add(Audioname[i], Audioclip[i]);
        }
    }

    public void Sound(string audioname)
    {
        if (Audios.ContainsKey(audioname))
        {
            for(int i = 0; i < AudioSources.Count; i++)
            {
                if (!AudioSources[i].isPlaying)
                {
                    AudioSources[i].clip = Audios[audioname];
                    AudioSources[i].time = 0.0f;
                    AudioSources[i].Play();
                    AudioSources[i].volume = audiosound / 100;
                    return;
                }
            }
            Debug.Log("오디오 소스가 부족하여 리소스를 재생할 수 없습니다.");
            return;
        }
        Debug.Log("다음 이름을 가진 오디오 리소스는 존재하지 않습니다.");
    }
    public void SoundWithTime(string audioname, float timesa)
    {
        if (Audios.ContainsKey(audioname))
        {
            for (int i = 0; i < AudioSources.Count; i++)
            {
                if (!AudioSources[i].isPlaying)
                {
                    AudioSources[i].clip = Audios[audioname];
                    AudioSources[i].time = timesa;
                    AudioSources[i].Play();
                    AudioSources[i].volume = audiosound / 100;
                    return;
                }
            }
            Debug.Log("오디오 소스가 부족하여 리소스를 재생할 수 없습니다.");
            return;
        }
        Debug.Log("다음 이름을 가진 오디오 리소스는 존재하지 않습니다.");
    }

    public void Sound3D(string audioname, Vector3 pos)
    {
        if (Audios.ContainsKey(audioname))
        {
            for (int i = 0; i < audio3dpool.Count; i++)
            {
                if (!audio3dpool[i].isPlaying)
                {
                    audio3dpool[i].clip = Audios[audioname];
                    audio3dpool[i].transform.position = pos;
                    audio3dpool[i].Play();
                    audio3dpool[i].volume = audiosound / 100;
                    return;
                }
            }
            var that = Instantiate(audio3D, pos, Quaternion.identity);
            audio3dpool.Add(that);
            that.transform.SetParent(transform);
            that.clip = Audios[audioname];
            that.Play();
            that.volume = (audiosound / 100) * 1.5f;
            return;
        }
        Debug.Log("다음 이름을 가진 오디오 리소스는 존재하지 않습니다.");
    }
    public void Soundoff(string audioname)
    {
        for(int i = 0; i < AudioSources.Count; i++)
        {
            if(AudioSources[i].clip == Audios[audioname] && AudioSources[i].isPlaying)
            {
                AudioSources[i].Stop();
                return;
            }
        }
    }
    public void Soundreset()
    {
        for (int i = 0; i < AudioSources.Count; i++)
        {
            AudioSources[i].Stop();
        }
    }
}
