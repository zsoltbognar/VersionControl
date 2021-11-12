using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SantaFactory.Abstrations;
using SantaFactory.Entities;

namespace SantaFactory
{
    public partial class Form1 : Form
    {
        List<Toy> _toys = new List<Toy>();
        private IToyFactory _toyFactory;

        public IToyFactory ToyFactory
        {
            get { return _toyFactory; }
            set { _toyFactory = value; }
        }

        public Form1()
        {
            InitializeComponent();
            ToyFactory = new IToyFactory();

            
        }

        
        private void CreateTimer_Tick(object sender, EventArgs e)
        {
            Ball  toy = (Ball)ToyFactory.CreateNew();
            _toys.Add(toy);
            mainPanel.Controls.Add(toy);
            toy.Left = -toy.Width;

 
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            var lastPosition = 0;
           
            foreach (var item in _toys)
            {
                item.MoveToy();
                if (item.Left> lastPosition)
                {
                    lastPosition = item.Left;

                }


            }
            if (lastPosition >= 1000)
            {
                var oldesToy = _toys[0];
                _toys.Remove(oldesToy);
                mainPanel.Controls.Remove(oldesToy);

            }
        }

    }
}
