using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabIndexBug
{
    [DesignTimeVisible(true)]
    public partial class MyCustomControl: ContentView
    {
        #region  属性和事件
        public static readonly BindableProperty HTitleProperty = BindableProperty.Create("HTitle", typeof(string),typeof(MyCustomControl),String.Empty);
        public string HTitle
        {
            get { return (string)GetValue(MyCustomControl.HTitleProperty); }
            set { SetValue(MyCustomControl.HTitleProperty, value); }
        }
        public static readonly BindableProperty LeftImgProperty = BindableProperty.Create("LeftImg", typeof(string), typeof(MyCustomControl), String.Empty);
        public string LeftImg {
            get { return (string)GetValue(MyCustomControl.LeftImgProperty); }
            set { SetValue(MyCustomControl.LeftImgProperty, value); }
        }

        public event EventHandler LeftClicked;        

        public static readonly BindableProperty RightImgProperty = BindableProperty.Create("RightImg", typeof(string), typeof(MyCustomControl), String.Empty);
        public string RightImg
        {
            get { return (string)GetValue(MyCustomControl.RightImgProperty); }
            set { SetValue(MyCustomControl.RightImgProperty, value); }
        }
        public event EventHandler RightClicked;
        #endregion
        public MyCustomControl()
        {
            InitializeComponent();
        }
        private void Top_left_Clicked(object sender, EventArgs e)
        {
            LeftClicked?.Invoke(sender,e);
        }

        private void Top_right_Clicked(object sender, EventArgs e)
        {
            RightClicked?.Invoke(sender,e);
        }
    }
}