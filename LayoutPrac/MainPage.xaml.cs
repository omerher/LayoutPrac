using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutPrac
{
    public partial class MainPage : ContentPage
    {
        private double margin;
        public MainPage()
        {
            InitializeComponent();
            margin = 0.02;
        }

        private void Up_Clicked(object sender, EventArgs e)
        {
            Rectangle c = AbsoluteLayout.GetLayoutBounds(circle);
            double x = c.X;
            double y = c.Y - margin;
            AbsoluteLayout.SetLayoutBounds(circle, new Rectangle(x, y, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        }

        private void Down_Clicked(object sender, EventArgs e)
        {
            Rectangle c = AbsoluteLayout.GetLayoutBounds(circle);
            double x = c.X;
            double y = c.Y + margin;
            AbsoluteLayout.SetLayoutBounds(circle, new Rectangle(x, y, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        }

        private void Left_Clicked(object sender, EventArgs e)
        {
            Rectangle c = AbsoluteLayout.GetLayoutBounds(circle);
            double x = c.X - margin;
            double y = c.Y;
            AbsoluteLayout.SetLayoutBounds(circle, new Rectangle(x, y, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        }

        private void Right_Clicked(object sender, EventArgs e)
        {
            Rectangle c = AbsoluteLayout.GetLayoutBounds(circle);
            double x = c.X + margin;
            double y = c.Y;
            AbsoluteLayout.SetLayoutBounds(circle, new Rectangle(x, y, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        }
    }
}
