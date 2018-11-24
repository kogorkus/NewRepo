using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace App5
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        delegate void MyMessage(string message);
        delegate int Result(int a, int b);
        delegate void Hello();
        delegate bool IsEqual(int x);
        public MainPage()
        {
            int[] arr = { 1, 2, 4, 5, 7, 7, 4, 3, 6 };
            this.InitializeComponent();
          
            int result = sum(arr, s => s > 4);
            tbName.Text = result.ToString();
        }

        private static int sum(int[] arr, IsEqual fun)
        {
            int result = 0;
            foreach(int i in arr)
            {
                if(fun(i))
                {
                    result++; 
                }
            }
            return result;
        }
        

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            
        }
        static void ShowMyMessage()
        {
           
        }
    }
}
