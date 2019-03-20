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

namespace _312576fileWriterExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnWrite_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(txtFileName.Text);
                sw.WriteLine(txtInput.Text);
                sw.Flush();
                sw.Close();
            } //end try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } //end catch
        }
        private void btnAppend_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(txtFileName.Text, true);
                sw.WriteLine(txtInput.Text);
                sw.Flush();
                sw.Close();
            } //end try
            //true behind txtFileName.Text
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } //end catch
        }
        private void btnsquares_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(txtFileName.Text);
                //sw.WriteLine(txt.Input.Text);
                //get number
                int theNumber;
                int.TryParse(txtInput.Text, out theNumber);
                //loop from 1 to the number
                for (int i = 1; i <= theNumber; i++)
                {
                    sw.WriteLine(i.ToString() + "\t" + i*i);
                    //list numbers from one to the number
                    //after each number add a tab
                    //after each tab add the square
                }              
                sw.Flush();
                sw.Close();
            } //end try
            //true behind txtFileName.Text
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } //end catch
        }


        
    }
}
/*char num1;
        private void btnsquares_Click(object sender, RoutedEventArgs e)
        {
            if (char.IsDigit(num1))
            {
                System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(txtFileName.Text, true);
                streamWriter.WriteLine(txtInput.Text);
                streamWriter.Flush();
                streamWriter.Close();
                num1* num1;

            }
            else
            {
                MessageBox.Show(ex.Message);
                }
            */