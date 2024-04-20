using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

[ConfigureSingleton(SingletonFlags.NoAutoInstance)]
public class OptionsMenuToManager : MonoSingleton<OptionsMenuToManager>
{
	public GameObject pauseMenu;

	public GameObject optionsMenu;

	public Slider mouseSensitivitySlider;

	private bool ignoreSensitivitySliderChange;

	public Toggle reverseMouseX;

	public Toggle reverseMouseY;

	public Slider simplifiedDistanceSlider;

	public GameObject simplifiedDistanceGroup;

	public Toggle simplifyEnemies;

	public Toggle outlinesOnly;

	public Slider outlineThickness;

	public Slider screenShakeSlider;

	public Toggle cameraTilt;

	public Toggle parryFlash;

	public Toggle discordIntegration;

	[FormerlySerializedAs("steamLeaderboards")]
	public Toggle levelLeaderboards;

	public Toggle seasonalEvents;

	public Toggle restartWarning;

	public Toggle sandboxWarning;

	public TMP_Dropdown resolutionDropdown;

	private Resolution[] resolutions;

	private List<Resolution> availableResolutions;

	public Toggle fullScreen;

	public TMP_Dropdown framerateLimiter;

	public Toggle simplerExplosions;

	public Toggle simplerFire;

	public Toggle simplerSpawns;

	public Toggle noEnviroParts;

	[SerializeField]
	private Toggle simpleNailPhysicsToggle;

	[HideInInspector]
	public static bool simpleNailPhysics;

	public Toggle bloodAndGore;

	[HideInInspector]
	public static bool bloodEnabled;

	public Toggle freezeGore;

	public Slider bloodstainChanceSlider;

	public Slider maxGoreSlider;

	public Toggle subtitles;

	public Slider masterVolume;

	public Slider musicVolume;

	private OptionsManager opm;

	private MusicManager muman;

	private Camera mainCam;

	private CameraController cc;

	public Slider fovSlider;

	public TMP_Dropdown weaponPosDropdown;

	public Toggle variationMemory;

	private List<string> options;

	public AudioClip normalJump;

	public AudioClip quakeJump;

	public bool selectedSomethingThisFrame;

	[Space]
	public BasicConfirmationDialog quitDialog;

	public BasicConfirmationDialog resetDialog;

	private NewMovement nmov;

	private void LateUpdate()
	{
	}

	private void Start()
	{
	}

	private new void OnEnable()
	{
	}

	private void SetPauseMenu()
	{
	}

	public void EnableGamepadLookAndMove()
	{
	}

	public void DisableGamepadLookAndMove()
	{
	}

	public void EnableGamepadMove()
	{
	}

	public void EnableGamepadLook()
	{
	}

	public void DisableGamepadMove()
	{
	}

	public void DisableGamepadLook()
	{
	}

	public void SetSelected(Selectable selectable)
	{
	}

	public void ResolutionChange(int stuff)
	{
	}

	public void SetFullScreen(bool stuff)
	{
	}

	public void FrameRateLimiter(int stuff)
	{
	}

	public void Pause()
	{
	}

	public void UnPause()
	{
	}

	public void RestartCheckpoint()
	{
	}

	public void RestartMission()
	{
	}

	public void RestartMissionNoConfirm()
	{
	}

	public void OpenOptions()
	{
	}

	public void CloseOptions()
	{
	}

	public void QuitMission()
	{
	}

	public void QuitMissionNoConfirm()
	{
	}

	public void QuitGame()
	{
	}

	public void CheckIfTutorialBeaten()
	{
	}

	public void ChangeLevel(string levelname)
	{
	}

	public void SimpleExplosions(bool stuff)
	{
	}

	public void SimpleFire(bool stuff)
	{
	}

	public void SimpleSpawns(bool stuff)
	{
	}

	public void DisableEnviroParts(bool stuff)
	{
	}

	public void SimpleNailPhysics(bool stuff)
	{
	}

	public void BloodAndGoreOn(bool stuff)
	{
	}

	public void FreezeGore(bool stuff)
	{
	}

	public void SimplifyEnemies(bool stuff)
	{
	}

	public void OutlinesOnly(bool stuff)
	{
	}

	public void SimplifyEnemiesDistance(float stuff)
	{
	}

	public void OutlineThickness(float stuff)
	{
	}

	public void MouseSensitivity(float stuff)
	{
	}

	public void UpdateSensitivitySlider(float stuff)
	{
	}

	public void ReverseMouseX(bool stuff)
	{
	}

	public void ReverseMouseY(bool stuff)
	{
	}

	public void ScreenShake(float stuff)
	{
	}

	public void CameraTilt(bool stuff)
	{
	}

	public void ParryFlash(bool stuff)
	{
	}

	public void DiscordIntegration(bool stuff)
	{
	}

	public void LevelLeaderboards(bool stuff)
	{
	}

	public void SeasonalEvents(bool stuff)
	{
	}

	public void RestartWarning(bool stuff)
	{
	}

	public void SandboxSaveWarning(bool stuff)
	{
	}

	public void VariationMemory(bool stuff)
	{
	}

	public void BloodStainChance(float stuff)
	{
	}

	public void maxGore(float stuff)
	{
	}

	public void MasterVolume(float stuff)
	{
	}

	public void MusicVolume(float stuff)
	{
	}

	public void SetSubtitles(bool state)
	{
	}

	public void FieldOfView(float stuff)
	{
	}

	public void WeaponPosition(int stuff)
	{
	}

	public void CheckEasterEgg()
	{
	}

	public OptionsMenuToManager()
	{

	}
}
