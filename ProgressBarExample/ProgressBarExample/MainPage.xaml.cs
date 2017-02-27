using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgressBarExample.Models;
using Xamarin.Forms;

namespace ProgressBarExample
{
    public partial class MainPage : ContentPage
    {
        private Player _player;
        private Enemy _enemy;
        public MainPage()
        {
            _player = new Player() {MaxHealth = 100, CurrentHealth = 100, Damage = 10};
            _enemy = new Enemy() {MaxHealth = 100, CurrentHealth = 100, Damage = 10};

            InitializeComponent();
        }

        private void Enemy_OnClicked(object sender, EventArgs e)
        {
            DealDamage((float)_player.Damage);
        }

        private void DealDamage(float damage)
        {
            if (_enemy.CurrentHealth > damage)
            {
                _enemy.CurrentHealth -= damage;
                EnemyHealthBar.Progress = (_enemy.CurrentHealth/_enemy.MaxHealth);
            }
            else
            {
                NextMonster();
            }
        }

        private void NextMonster()
        {
            _enemy = new Enemy() {MaxHealth = _enemy.MaxHealth*2, CurrentHealth = _enemy.CurrentHealth*2, Damage = _enemy.Damage*2};
            EnemyHealthBar.Progress = 1.0;
            StageBar.Progress += 0.1;
        }
    }
}
