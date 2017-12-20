using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FoodStock01;

namespace FoodStock01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FoodPage1 : ContentPage
    {
        String s = "http://cookpad.com/search/";

        public FoodPage1(string title)
        {
            //タイトル
            Title = title;

            InitializeComponent();
        }

        void ChackBoxChanged(object sender, bool isChecked)
        {
            //選択された時の処理
            if (isChecked)
            {
                s += ((CheckBox)sender).Text + "　";
                //DisplayAlert("URL", s, "ok");
            }
            //選択が外された時の処理
            else
            {
                s = s.Replace(((CheckBox)sender).Text +"　", "");
                //DisplayAlert("URL", s, "ok");
            }
        }

 　      void OnSearch_Clicked(object sender, EventArgs args)
        {
            //ページ遷移
            //Navigation.PushAsync(new NextPage(s));
            DisplayAlert("url",s,"ok");
        }

        private void Update_Button_Clicked(object sender, EventArgs e)
        {
            Title = "食材リスト";

            InitializeComponent();
            
        }

        void Delete_Clicked(object sender, EventArgs e)
        {
            string no1 = ((CustomButtonDelete)sender).NoText;

            int f_no1 = int.Parse(no1);//
            /***ここから試し***/
            FoodModel.DeleteFood(f_no1);

            //Title = "保存食品リスト";

            //InitializeComponent();
        }
    }
}