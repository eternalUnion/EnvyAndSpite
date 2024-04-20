[ConfigureSingleton(SingletonFlags.PersistAutoInstance)]
public class PreviousMissionSaver : MonoSingleton<PreviousMissionSaver>
{
	public int previousMission;

	public PreviousMissionSaver()
	{

	}
}
