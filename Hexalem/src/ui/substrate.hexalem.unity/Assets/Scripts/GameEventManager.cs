using Substrate.Hexalem;
using UnityEngine;
using static Assets.Scripts.ScreensSubState.MainPlaySubState;

namespace Assets.Scripts
{
    public class GameEventManager : Singleton<GameEventManager>
    {
        public delegate void StartNewGameHandler(string gameType);
        public static event StartNewGameHandler StartNewGameDelegate;

        public void OnStartNewGame(string gameType)
        {
            Debug.Log("GameEventManager > OnStartGame");
            StartNewGameDelegate(gameType);
        }

        public delegate void RessourcesChangedHandler(HexaPlayer player);
        public static event RessourcesChangedHandler RessourcesChangedDelegate;

        public void OnRessourcesChanged(HexaPlayer player)
        {
            Debug.Log("GameEventManager > OnRessourcesChanged");
            RessourcesChangedDelegate(player);
        }

        public delegate void VisualGameHandler(int nbMillisecond, StateType state);
        public static event VisualGameHandler VisualGameDelegate;

        public void OnVisualGame(int nbMillisecond, StateType state)
        {
            Debug.Log("GameEventManager > OnVisualGame");
            VisualGameDelegate(nbMillisecond, state);
        }

        public delegate void ZoomHandler(bool zoomIn);
        public static event ZoomHandler ZoomHandlerDelegate;

        public void OnZoom(bool zoomIn)
        {
            if (zoomIn)
                Debug.Log("GameEventManager > ZoomIn");
            else
                Debug.Log("GameEventManager > ZoomOut");
            Debug.Log("GameEventManager > OnVisualGameHelperChanged");
            ZoomHandlerDelegate(zoomIn);
        }

        public delegate void TileDetailsHandler(bool show, (int, int) coords, HexaTile tile, bool canUpgrade);
        public static event TileDetailsHandler TileDetailsHandlerDelegate;

        public void OnTileDetails(bool show, (int, int) coords, HexaTile tile, bool canUpgrade)
        {
            Debug.Log("GameEventManager > OnTileDetailsHandlerChanged");
            TileDetailsHandlerDelegate(show, coords, tile, canUpgrade);
        }

        public delegate void UpgradeTileHandler((int, int) coords);
        public static event UpgradeTileHandler UpgradeTileHandlerDelegate;

        public void OnUpgradeTile((int, int) coords)
        {
            Debug.Log("GameEventManager > OnUpgradeTile");
            UpgradeTileHandlerDelegate(coords);
        }
    }
}