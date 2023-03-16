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

namespace testCsharp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            result.IsReadOnly = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (five.Text.Length <= 2 && four.Text.Length <= 2 && three.Text.Length <= 2 && two.Text.Length <= 2)
            {
                if (five.Text != "" && four.Text != "" && three.Text != "" && two.Text != "")
                {
                    int countfive = Convert.ToInt16(five.Text);
                    int countfour = Convert.ToInt16(four.Text);
                    int countthree = Convert.ToInt16(three.Text);
                    int counttwo = Convert.ToInt16(two.Text);
                    int count = countfive + countfour + countthree + counttwo;
                    double res, res1;

                    if (countfive != 0 || countfour != 0 || countthree != 0 || counttwo != 0)
                    {
                        res = (countfive * 5) + (countfour * 4) + (countthree * 3) + (counttwo * 2);
                        res1 = res / count;
                        result.Text = res1.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                        five.Text = "";
                        four.Text = "";
                        three.Text = "";
                        two.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Error");
            }

        }
    }
}
