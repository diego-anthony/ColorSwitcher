using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ColorSwitcher
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            sldRojo.ValueChanged += sldChanged;
            sldVerde.ValueChanged += sldChanged;
            sldAzul.ValueChanged += sldChanged;
        }

        private void sldChanged(object sender, ValueChangedEventArgs e)
        {
            Color color = new Color(sldRojo.Value,sldVerde.Value,sldAzul.Value);
            BoxColor.Color = color;
            codHexa.Text = ColorToHexadecimal(color);
        }

        private string ColorToHexadecimal(Color color)
        {
            var rojo = (int)(color.R *255);
            var verde = (int)(color.G * 255);
            var azul = (int)(color.B * 255);
            var alpha = (int)(color.A * 255);
            return $"#{rojo:X2}{verde:X2}{azul:X2}{alpha:X2}";
        }
    }
}
