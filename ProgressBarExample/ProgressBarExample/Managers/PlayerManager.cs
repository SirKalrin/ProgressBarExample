using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgressBarExample.Models;

namespace ProgressBarExample.Managers
{
    public class PlayerManager
    {
        private static PlayerManager _instance;
        public int MonsterCount { get; set; }

        private Player _player;
        private Enemy _enemy;

        private PlayerManager()
        {
            _player = new Player() { MaxHealth = 100, CurrentHealth = 100, Damage = 10 };
            _enemy = new Enemy() { MaxHealth = 100, CurrentHealth = 100, Damage = 10 };
            MonsterCount = 0;
        }

        public static PlayerManager GetInstance()
        {
            return _instance ?? new PlayerManager();
        }

        public double DealDamage()
        {
            if (_enemy.CurrentHealth > _player.Damage)
            {
                _enemy.CurrentHealth -= _player.Damage;
                return _enemy.CurrentHealth / _enemy.MaxHealth;
            }
            else
            {
                MonsterCount++;
                return NextMonster();
            }        
        }



        public double NextMonster()
        {
            _enemy = new Enemy() { MaxHealth = _enemy.MaxHealth * 2, CurrentHealth = _enemy.MaxHealth * 2, Damage = _enemy.Damage * 2 };
            return 1;
        }
    }
}
