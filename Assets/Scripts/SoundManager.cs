using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��ǥ: BGM, ���� ����, ������ ȹ�� ���带 ����Ѵ�.
// �ʿ�Ӽ�: BGM, ���� ����, ������ ȹ�� ���� �����Ŭ��
public class SoundManager : MonoBehaviour
{
    public AudioSource bgmAudioSource;
    public AudioSource effAudioSource;

    public List<AudioClip> bgmAudioClips = new List<AudioClip>();
    public List<AudioClip> explosionAudioClips = new List<AudioClip>();
    public List<AudioClip> itemAudioClips = new List<AudioClip>();

}
