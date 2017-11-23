using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
            InitializeComponent();
            MainListView.ItemsSource = new List<Person>
            {
                new Person
                {
                    Name="Aswin",
                    Age=18
                },


                new Person
                {
                    Name="Anjana",
                    Age=18
                },

                new Person
                {
                    Name="Anjana and Aswin",
                    Age=18
                },

                new Person
                {
                    Name="Anju",
                    Age=15
                }
            };
		}
	}
}
