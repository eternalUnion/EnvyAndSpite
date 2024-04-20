using UnityEngine.SceneManagement;

[ConfigureSingleton(SingletonFlags.NoAutoInstance | SingletonFlags.DestroyDuplicates)]
public class PresenceController : MonoSingleton<PresenceController>
{
	public string[] diffNames;

	private bool trackingTimeInSandbox;

	private TimeSince timeInSandbox;

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	public static void UpdateCyberGrindWave(int wave)
	{
	}

	private void SceneManagerOnsceneLoaded(Scene _, LoadSceneMode mode)
	{
	}

	public void AddToStatInt(string statKey, int amount)
	{
	}

	private void OnApplicationQuit()
	{
	}

	public PresenceController()
	{

	}
}
