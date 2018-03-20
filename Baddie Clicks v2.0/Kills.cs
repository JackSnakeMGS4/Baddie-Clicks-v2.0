using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baddie_Clicks_v2._0
{
    class Kills
    {
        private int killCount = 0;
        public int KillCount
        {
            get
            {
                return  killCount;
            }
            set
            {
                UpdateKills();
            }
        }
        private void UpdateKills()
        {
            killCount++;
        }

        private int totalCount = 0;
        public int TotalCount
        {
            get
            {
                return totalCount;
            }
            set
            {
                UpdateTotal();
            }
        }
        private void UpdateTotal()
        {
            totalCount++;
        }

        private int enemyCount = 0;
        public int EnemyCount
        {
            get
            {
                return enemyCount;
            }
            set
            {
                UpdateEnemy();
            }
        }
        private void UpdateEnemy()
        {
            enemyCount++;
        }
    }
}
