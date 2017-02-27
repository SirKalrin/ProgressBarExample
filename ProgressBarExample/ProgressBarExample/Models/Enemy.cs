using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProgressBarExample.Models
{
    class Enemy
    {
        public string Id { get; set; }
        public double MaxHealth { get; set; }
        public double CurrentHealth { get; set; }
        public Image Image { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Damage { get; set; }
    }
}
