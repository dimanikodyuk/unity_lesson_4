using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        GameMenu._onButtonCredits += ButtonCredits;
        GameMenu._onButtonCinematic += ButtonCinematics;
        GameMenu._onButtonExit += ButtonExit;
        GameMenu._onButtonApply += ButtonApply;
        GameMenu._onResolutionDropdown += ResolutionDropdown;
        GameMenu._onQualitynDropdown += QualityDropdown;
        GameMenu._onMasterVolume += MasterVolume;
        GameMenu._onMusicVolume += MusicVolume;
        GameMenu._onFullscreenToggle += FullscreenToggle;
        GameMenu._onSoundBackgroundToggle += SoundBackgroundToggle;
        GameMenu._onChallengingToggle += ChallengingToggle;
        GameMenu._onFriendsToggle += FriendsToggle;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ButtonCredits()
    {
        Debug.Log("Нажата кнопка [ButtonCredits]");
    } 
    
    
    private void ButtonCinematics()
    {
        Debug.Log("Нажата кнопка [ButtonCinematics]");
    } 
    
    private void ButtonExit()
    {
        Debug.Log("Нажата кнопка [ButtonExit]");
    }
    
    private void ButtonApply()
    {
        Debug.Log("Нажата кнопка [ButtonApply]");
    }  

    private void ResolutionDropdown(int indexValue, string valueText)
    {
        Debug.Log($"Значение выпадающего списка [ResolutionDropdown] изменено на индекс {indexValue}, что равно {valueText}");
    }  

    private void QualityDropdown(int indexValue, string valueText)
    {
        Debug.Log($"Значение выпадающего списка [ResolutionDropdown] изменено на индекс {indexValue}, что равно {valueText}");
    }

    private void MasterVolume(float volumeValue)
    {
        Debug.Log($"Изменено значение параметра MasterVolume на {volumeValue}");
    }

    private void MusicVolume(float volumeValue)
    {
        Debug.Log($"Изменено значение параметра MusicVolume на {volumeValue}");
    }

    private void FullscreenToggle(bool isFullscreen)
    {
        Debug.Log($"[FullscreenToggle] Изменено значение на {isFullscreen}");
    }

    private void SoundBackgroundToggle(bool isSoundBackground)
    {
        Debug.Log($"[SoundBackgroundToggle] Изменено значение на {isSoundBackground}");
    }

    private void ChallengingToggle(bool isChallenging)
    {
        Debug.Log($"[ChallengingToggle] Изменено значение на {isChallenging}");
    }
    
    private void FriendsToggle(bool isFriends)
    {
        Debug.Log($"[FriendsToggle] Изменено значение на {isFriends}");
    }
}
