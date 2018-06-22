using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Note
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        string filePath = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        // 開啟檔案按鈕
        private void OpenBtn_Click(object sender, RoutedEventArgs e)
        {
            //開啟檔案視窗
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            //顯示視窗
            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                //取得路徑 
                filePath = dlg.FileName;
                //讀檔
                TextArea.Text = System.IO.File.ReadAllText(filePath);
            }
        }


        //存檔
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            //開啟檔案視窗
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();

            //顯示視窗
            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                //取得路徑 
                filePath = dlg.FileName;

                //存檔
                System.IO.File.WriteAllText(filePath, TextArea.Text);
            }
        }
        //新開檔案
        private void NewBtn_Click(object sender, RoutedEventArgs e)
        {
            //清除
            TextArea.Clear();
        }
        //開啟舊檔
        private void AsBtn_Click(object sender, RoutedEventArgs e)
        {
            //開啟檔案視窗
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();

            //顯示視窗
            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                //取得路徑 
                filePath = dlg.FileName;

                //存檔
                System.IO.File.WriteAllText(filePath, TextArea.Text);
            }
        }

        //小字體
        private void Small_Click(object sender, RoutedEventArgs e)
        {
            double fsize = TextArea.FontSize;
            if (fsize != 12.0)
            {
                TextArea.FontSize = 14;
            }
        }

        //中字體
        private void Medium_Click(object sender, RoutedEventArgs e)
        {
            double fsize = TextArea.FontSize;
            if (fsize != 18.0)
            {
                TextArea.FontSize = 18;
            }
        }

        //大字體
        private void Big_Click(object sender, RoutedEventArgs e)
        {
            double fsize = TextArea.FontSize;
            if (fsize != 24.0)
            {
                TextArea.FontSize = 24;
            }
        }

        //改成深色背景
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextArea.Background = Brushes.DimGray;
            TextArea.Foreground = Brushes.White;
        }

        //改成淺色背景
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextArea.Background = Brushes.White;
            TextArea.Foreground = Brushes.Gray;
        }
    }
}
