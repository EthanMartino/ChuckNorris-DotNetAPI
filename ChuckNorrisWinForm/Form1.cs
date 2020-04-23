using ChuckNorrisAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuckNorrisWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void jokeBtn_ClickAsync(object sender, EventArgs e)
        {
            if (categoriesCbx.SelectedIndex >=0)
            {
                string category = categoriesCbx.SelectedItem.ToString();
            }
            Joke joke = await ChuckNorrisClient.GetRandomJoke();
            jokeLbl.Text = joke.JokeText;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            IEnumerable<string> categories = await ChuckNorrisClient.GetCategories();
            foreach (string category in categories)
            {
                categoriesCbx.Items.Add(category);
            }
        }
    }
}
