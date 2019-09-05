using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabIndexBug
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestPages : ContentPage
    {
        private List<CheckInvLinesModel> lists;
        public TestPages()
        {
            InitializeComponent();
            lists = new List<CheckInvLinesModel>();
            for (int i = 0; i < 5; i++){
                lists.Add(new CheckInvLinesModel { ProductCode = "0000"+i, isChecked = false });
            }
            this.Appearing += TestPages_Appearing;
        }

        private void TestPages_Appearing(object sender, EventArgs e)
        {
            listview.ItemsSource = lists;
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var model = ((StackLayout)sender).BindingContext as CheckInvLinesModel;
            model.isChecked = !model.isChecked;
        }
        private void Headscroller_Scrolled(object sender, ScrolledEventArgs e)
        {
            //在此地方需要滚动内容区域
        }
        private async void Itemscroller_Scrolled(object sender, ScrolledEventArgs e)
        {
            await headscroller.ScrollToAsync(e.ScrollX, e.ScrollY, false);
        }
    }
    class CheckInvLinesModel : INotifyPropertyChanged
    {
        public string ProductCode { get; set; }

        private bool Ischecked;
        public bool isChecked
        {
            get { return this.Ischecked; }
            set
            {
                this.Ischecked = value;
                NotifyPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}