using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfIntroOvl3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// /* Det har vaeret en maerkelig opgave. Den soelle opgavebeskrivelse der har vaeret, passer ikke ind i de exempler der er givet, saa det er derfor opgaven ikke ser ud til at give mening. */
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void VisAdvarsel_Click(object sender, RoutedEventArgs e)
        {// Opretter beskeder og buttontekst til advarsler--------------------------------------------------------------------------
            MessageClass Msg1 = new MessageClass("Er det kommunistiske parti det bedste i verden?", "100%","Ja");
            MessageClass Msg2 = new MessageClass("UV indekset er højt i dag, har du husket solcreme?", "Ja", "Nej");
            MessageClass Msg3 = new MessageClass("Er du vågen?", "Ja", "Nej");
            MessageClass Msg4 = new MessageClass("Går du i skole?", "Ja", "Nej");
            MessageClass Msg5 = new MessageClass("Er du en tøs?", "Ja", "STODDER!");
            MessageClass Msg6 = new MessageClass("Det bliver regnvejr i dag, har du husket ordentligt tøj?", "Ja", "Nej");
            //------------------------------------------------------------------------------------------------------------------------
            List<MessageClass> MsgList = new List<MessageClass>() {Msg1, Msg2, Msg3, Msg4, Msg5, Msg6}; //Putter beskederne i en liste, hvor de kan blive udtraekket tilfaeldigt

            Random Rnd = new Random();
            int Item = Rnd.Next(0, (MsgList.Count - 1));

            // Tildeler diverse elementer, om hvad der skal staa i dem.
            
            var dialog = new Window1();
            var MainMenu = new MainWindow();
            MainMenu.BeskedBar.Text = (MsgList[Item].MsgItem);
            dialog.AdvarselText.Text = (MsgList[Item].MsgItem);
            dialog.yButton.Content = (MsgList[Item].AnsOne);
            dialog.nButton.Content = (MsgList[Item].AnsTwo);
            bool? Result = dialog.ShowDialog();
            if (Result == true)
            {

                BeskedBar.Text = MsgList[Item].MsgItem;
            }
            else
            {

                BeskedBar.Text = "Ok";
            }


        }
    }
}
