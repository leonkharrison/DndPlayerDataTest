using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndPlayerDataTest
{
    [Serializable]
    public class PlayerInfo
    {
        public string PlayerName { get; set; }
        public int PlayerXP { get; set; }
        public string PlayerClass { get; set; }
        public string PlayerAlignment { get; set; }
        public string PlayerRace { get; set; }

        public PlayerInfo()
        {
            ClearAll();
        }

        private void ClearAll()
        {
            PlayerName = string.Empty;
            PlayerXP = 0;
        }
    }
}
