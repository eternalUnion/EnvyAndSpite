using UnityEngine;
using UnityEngine.Audio;

[ConfigureSingleton(SingletonFlags.NoAutoInstance)]
[DefaultExecutionOrder(-10)]
public class AudioMixerController : MonoSingleton<AudioMixerController>
{
	public AudioMixer allSound;

	public AudioMixer goreSound;

	public AudioMixer musicSound;

	public AudioMixer doorSound;

	public AudioMixer unfreezeableSound;

	[HideInInspector]
	public float musicVolume;

	[HideInInspector]
	public float optionsMusicVolume;

	public bool forceOff;

	protected override void Awake()
	{
	}

	private void Update()
	{
	}

	public void SetMusicVolume(float volume)
	{
	}

	public float CalculateMusicVolume(float volume)
	{
		return 0f;
	}

	public AudioMixerController()
	{

	}
}
