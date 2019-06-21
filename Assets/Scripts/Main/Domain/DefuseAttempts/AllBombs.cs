using System.Linq;
using UnityEngine;

namespace Main.Domain.DefuseAttempts
{
    public class AllBombs
    {
        private readonly IBomb[] _bombs;
        private readonly IRandom _random;

        public AllBombs(IRandom random, IBomb[] bombs, IDeviceInfo deviceInfo)
        {
            _random = random;
            _bombs = bombs
                .Where(bomb => bomb.Language == BombLanguage.None || bomb.Language == deviceInfo.GetDeviceBombLanguage())
                .ToArray();
        }
        
        public virtual string PickRandomBombId()
        {
            var bombIndex = _random.Range(0, _bombs.Length);
            return _bombs[bombIndex].Id;
        }
        
        public virtual IBomb GetByBombId(string bombId)
        {
            return _bombs.First(bomb => bomb.Id == bombId);
        }
    }
}