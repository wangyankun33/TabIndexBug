using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabIndexBug
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class loading : PopupPage
    {
        public loading(string loadText = "")
        {
            InitializeComponent();
            this.loadText.Text = loadText;
        }
    }
}