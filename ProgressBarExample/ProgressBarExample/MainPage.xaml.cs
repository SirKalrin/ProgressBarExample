using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProgressBarExample
{
    public partial class MainPage : ContentPage
    {
        public float Damage { get; set; }
        public MainPage()
        {
            InitializeComponent();
            Damage = 0.1f;
        }

        private void Enemy_OnClicked(object sender, EventArgs e)
        {
            DealDamage(Damage);
        }

        private void DealDamage(float damage)
        {
            if (EnemyHealthBar.Progress > 0f)
            {
                EnemyHealthBar.Progress -= Damage;
            }
            else
            {
                NextMonster();
            }
        }

        private void NextMonster()
        {
            
        }
    }
}
