using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;





namespace Carouser_Movil
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<FileImageSource> imageSources = new ObservableCollection<FileImageSource>();
        public MainPage()
        {
            InitializeComponent();

            imageSources.Add("img.jpg");
            imageSources.Add("img2.jpg");
            imageSources.Add("img3.jpg");
            imageSources.Add("img4.jpg");
            imageSources.Add("img5.jpg");
            imageSources.Add("img6.jpg");
            imageSources.Add("img7.jpg");
            imageSources.Add("img8.jpg");
            imageSources.Add("img9.jpg");
            imageSources.Add("img10.jpg");
            imageSources.Add("img11.jpg");
            imageSources.Add("img12.jpg");
            imageSources.Add("img13.jpg");
            imageSources.Add("img14.jpg");
            imageSources.Add("img15.jpg");
            imageSources.Add("img16.jpg");

            imgSlider.Images = imageSources;
        }
    }
}