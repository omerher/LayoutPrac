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

            if (y < 0)
            {
                y = 0;
                up.IsEnabled = false;
            }
            else
            {
                down.IsEnabled = true;
            }

            AbsoluteLayout.SetLayoutBounds(circle, new Rectangle(x, y, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        }

        private void Down_Clicked(object sender, EventArgs e)
        {
            Rectangle c = AbsoluteLayout.GetLayoutBounds(circle);
            double x = c.X;
            double y = c.Y + margin;

            if (y > 1)
            {
                down.IsEnabled = false;
                y = 1;
            }
            else
            {
                up.IsEnabled = true;
            }

            AbsoluteLayout.SetLayoutBounds(circle, new Rectangle(x, y, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        }

        private void Left_Clicked(object sender, EventArgs e)
        {
            Rectangle c = AbsoluteLayout.GetLayoutBounds(circle);
            double x = c.X - margin;
            double y = c.Y;

            if (x < 0)
            {
                left.IsEnabled = false;
                x = 0;
            }
            else
            {
                right.IsEnabled = true;
            }

            AbsoluteLayout.SetLayoutBounds(circle, new Rectangle(x, y, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        }

        private void Right_Clicked(object sender, EventArgs e)
        {
            Rectangle c = AbsoluteLayout.GetLayoutBounds(circle);
            double x = c.X + margin;
            double y = c.Y;

            if (x > 1)
            {
                x = 1;
                right.IsEnabled = false;
            }
            else
            {
                left.IsEnabled = true;
            }

            AbsoluteLayout.SetLayoutBounds(circle, new Rectangle(x, y, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        }
    }
}
