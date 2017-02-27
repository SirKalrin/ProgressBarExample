using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgressBarExample.Managers;
using ProgressBarExample.Models;
using Xamarin.Forms;

namespace ProgressBarExample
{
    public partial class MainPage : ContentPage
    {
        private PlayerManager _playerMgr;
        private float _stages = 10;
        public MainPage()
        {
            InitializeComponent();
            _playerMgr = PlayerManager.GetInstance();    
        }

        private void Enemy_OnClicked(object sender, EventArgs e)
        {
            EnemyHealthBar.Progress = _playerMgr.DealDamage();
            StageBar.Progress = _playerMgr.MonsterCount / _stages;
        }


    }
}
