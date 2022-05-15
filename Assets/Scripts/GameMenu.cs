using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameMenu : MonoBehaviour
{
    [SerializeField] Button _buttonCredits;
    [SerializeField] Button _buttonCinematic;
    [SerializeField] Button _buttonExit;
    [SerializeField] Button _buttonApply;
    [SerializeField] TMP_Dropdown  _resolutionDropdown;
    [SerializeField] TMP_Dropdown _qualityDropdown;
    [SerializeField] Slider _masterVolumeSlider;
    [SerializeField] Slider _musicVolumeSlider;
    [SerializeField] Toggle _fullscreenToggle;
    [SerializeField] Toggle _soundBackgroundToggle;
    [SerializeField] Toggle _challengingToggle;
    [SerializeField] Toggle _friendsSpectateToggle;

    public static Action _onButtonCredits;
    public static Action _onButtonCinematic;
    public static Action _onButtonExit;
    public static Action _onButtonApply;
    public static Action<int, string> _onResolutionDropdown;
    public static Action<int, string> _onQualitynDropdown;
    public static Action<float> _onMasterVolume;
    public static Action<float> _onMusicVolume;
    public static Action<bool> _onFullscreenToggle;
    public static Action<bool> _onSoundBackgroundToggle;
    public static Action<bool> _onChallengingToggle;
    public static Action<bool> _onFriendsToggle;

    // Start is called before the first frame update
    void Start()
    {
        _buttonCredits.onClick.AddListener(ButtonCredits);
        _buttonCinematic.onClick.AddListener(ButtonCinematic);
        _buttonExit.onClick.AddListener(ButtonExit);
        _buttonApply.onClick.AddListener(ButtonApply);
        _resolutionDropdown.onValueChanged.AddListener(ResolutionDropdown);
        _qualityDropdown.onValueChanged.AddListener(QualityDropdown);
        _masterVolumeSlider.onValueChanged.AddListener(MasterVolume);
        _musicVolumeSlider.onValueChanged.AddListener(MusicVolume);
        _fullscreenToggle.onValueChanged.AddListener(FullscreenToggle);
        _soundBackgroundToggle.onValueChanged.AddListener(SoundBackgroundToggle);
        _challengingToggle.onValueChanged.AddListener(ChallengingToggle);
        _friendsSpectateToggle.onValueChanged.AddListener(FriendsToggle);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ButtonCredits()
    {
        _onButtonCredits?.Invoke();
    }

    private void ButtonCinematic()
    {
        _onButtonCinematic?.Invoke();
    }

    private void ButtonExit()
    {
        _onButtonExit?.Invoke();
    }

    private void ButtonApply()
    {
        _onButtonApply?.Invoke();
    }

    private void ResolutionDropdown(int value)
    {
        _onResolutionDropdown?.Invoke(value, _resolutionDropdown.options[value].text);
    } 
    
    private void QualityDropdown(int value)
    {
        _onQualitynDropdown?.Invoke(value, _qualityDropdown.options[value].text);
    }

    private void MasterVolume(float volumeValue)
    {
        _onMasterVolume?.Invoke(volumeValue);
    }
    
    private void MusicVolume(float volumeValue)
    {
        _onMusicVolume?.Invoke(volumeValue);
    }
    
    private void FullscreenToggle(bool isFullscreen)
    {
        _onFullscreenToggle?.Invoke(isFullscreen);
    } 
    
    private void SoundBackgroundToggle(bool isSoundBackground)
    {
        _onSoundBackgroundToggle?.Invoke(isSoundBackground);
    } 
    
    private void ChallengingToggle(bool isChallenging)
    {
        _onChallengingToggle?.Invoke(isChallenging);
    }
    
    private void FriendsToggle(bool isFriends)
    {
        _onChallengingToggle?.Invoke(isFriends);
    }
}
