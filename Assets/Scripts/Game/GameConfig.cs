using UnityEngine;

[CreateAssetMenu(fileName = "GameConfig", menuName = "Scriptable Objects/GameConfig")]
public class GameConfig : ScriptableObject
{
    [Header("Player")]
    public int minPlayers = 3;
    public int maxPlayers = 8;
    public int PlayerCount = 4;

    [Header("Imposter Settings")]
    public int maxImposter = 3;
    public int minImposter = 0;
    public int ImposterCount = 1;
    public bool RandomImpostersCount = false;

    [Header("Game Count")]
    public int TotalGamesPlayed = 0;

    [Header("Genre Selection")]
    public string SelectedGenre = "Example Genre";



    public void IncrementGamesPlayed()
    {
        TotalGamesPlayed++;
    }

    public void PassThroughPlayerCount (int count)
    {
        PlayerCount = count;
    }

}
