using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SEMANA09
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwipeDemo : ContentPage
    {
        public SwipeDemo()
        {
            InitializeComponent();
        }
        void Onswiped (object sender, EventArgs e)
        {
            if (direction =="Right")
                ((BoxView)sender).BackgroundColor= Color.Red;
            if (direcction == "Left")
                ((BoxView)sender).BackgroundColor= Color.Yellow;
            if (direcction == "Up")
                ((BoxView)sender).BackgroundColor = Color.Green;
            if (direcction == "Down")
                ((BoxView)sender).BackgroundColor = Color.Blue;

            _label.Text=$"You swiped: {e.Direction.ToString()}";
        }
    }
}