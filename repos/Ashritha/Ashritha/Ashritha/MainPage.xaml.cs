using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ashritha
{
    public partial class MainPage : ContentPage
    {
        Button loginButton;
        StackLayout layout;
        public MainPage()
        {
            layout = new StackLayout
            {
                Children =
                {
                    new Label { Text = "Please log in" },
                    new Label { Text = "Username", TextColor = Color.Black },
                    //new Entry (),
                    new Label { Text = "Password", TextColor = Color.Black },
                    //new Entry { IsPassword = true },

                }
            };

            loginButton = new Button { Text = "Login" };

            layout.Children.Add(loginButton);

            Content = layout;

            loginButton.Clicked += (sender, e) =>
            {
                Debug.WriteLine("Clicked !");
            };
        }
    }
}
