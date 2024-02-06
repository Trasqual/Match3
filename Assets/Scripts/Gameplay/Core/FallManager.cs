using Main.Utilities;
using System;
using System.Collections.Generic;

namespace Main.Gameplay.Core
{
    public class FallManager : Singleton<FallManager>
    {
        public Action OnCompleted;

        private List<Tile> _tiles = new();

        public void AddRequester(Tile tile)
        {
            if (!_tiles.Contains(tile))
                _tiles.Add(tile);
        }

        public void RemoveRequester(Tile tile)
        {
            if (_tiles.Contains(tile))
                _tiles.Remove(tile);
            if (_tiles.Count <= 0)
            {
                OnCompleted?.Invoke();
            }
        }
    }
}
