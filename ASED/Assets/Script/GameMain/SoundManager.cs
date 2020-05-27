using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public enum BGM_NAME
{
    TITLE,
    STAGE_SELECT,
    MAIN,
    RESULT,
    MAX,
};

public enum SE_NAME
{
    TITLE_0,
    MAX,
};


public class SoundManager : MonoBehaviour
{

    protected static SoundManager instance;

    public static SoundManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = (SoundManager)FindObjectOfType(typeof(SoundManager));

                if (instance == null)
                {
                    Debug.LogError("SoundManager Instance Error");
                }
            }

            return instance;
        }
    }

    // AudioSource
    // BGM
    private AudioSource BGMsource;
    // SE
    private AudioSource[] SEsources = new AudioSource[(int)SE_NAME.MAX];

    // AudioClip
    // BGM
    public AudioClip[] BGM;
    // SE
    public AudioClip[] SE;

    void Awake()
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("SoundManager");

        // AudioSourceにコンポーネントを追加する

        // BGM AudioSource
        BGMsource = gameObject.AddComponent<AudioSource>();
        // BGMのループ有向
        BGMsource.loop = true;

        // SE AudioSource
        for (int i = 0; i < SEsources.Length; i++)
        {
            SEsources[i] = gameObject.AddComponent<AudioSource>();
        }
    }

    //BGM再生
    public void PlayBGM(int index)
    {
        if (0 > index || BGM.Length <= index)
        {
            return;
        }
        //同じBGMの場合は何もしない
        if (BGMsource.clip == BGM[index])
        {
            return;
        }
        BGMsource.Stop();
        BGMsource.clip = BGM[index];
        BGMsource.Play();
    }

    // BGM停止
    public void StopBGM()
    {
        BGMsource.Stop();
        BGMsource.clip = null;
    }

    // SE再生
    public void PlaySE(int index)
    {
        if (0 > index || SE.Length <= index)
        {
            return;
        }

        // 再生中でないAudioSourceで鳴らす
        foreach (AudioSource source in SEsources)
        {
            if (false == source.isPlaying)
            {
                source.clip = SE[index];
                source.Play();
                return;
            }
        }
    }

    // SEを一度だけ再生する
    public void PlaySEonce(int index)
    {
        if (0 > index || SE.Length <= index)
        {
            return;
        }
        if (SEsources[index].isPlaying)
        {
            SEsources[index].Stop();
        }

        if (SEsources[index].clip != SE[index])
        {
            SEsources[index].clip = SE[index];
        }
        SEsources[index].Play();
        SEsources[index].loop = false;

    }

    //SEをループで再生させる
    public void PlaySEloop(int index)
    {
        if (0 > index || SE.Length <= index)
        {
            return;
        }
        if (SEsources[index].isPlaying)
        {
            SEsources[index].Stop();
        }

        if (SEsources[index].clip != SE[index] || SEsources[index].clip == null)
        {
            SEsources[index].clip = SE[index];
        }
        SEsources[index].Play();
        SEsources[index].loop = true;
    }

    // 指定したSEを全て停止
    public void StopSEindex(int index)
    {
        if (true == SEsources[index].isPlaying)
        {
            if (SEsources[index].clip == SE[index])
            {
                SEsources[index].Stop();
                SEsources[index].clip = null;
            }
        }
    }

    //全SEを停止
    public void StopSE()
    {
        //全てのSE用のAudioSouceを停止する
        foreach (AudioSource source in SEsources)
        {
            source.Stop();
        }
    }
}
