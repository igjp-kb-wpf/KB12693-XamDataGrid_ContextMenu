using Infragistics.Controls.Menus;
using Infragistics.Windows;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.DataPresenter.Events;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using System.Windows.Threading;

namespace XamDataGrid_ContextMenu
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void contextMenu_Opening(object sender, OpeningEventArgs e)
        {
            List<CellValuePresenter> cells = e.GetClickedElements<CellValuePresenter>();

            if (cells.Count == 0 )
            {
                e.Cancel = true;
            }
            else
            {
                xamDataGrid1.SelectedItems.Records.Clear();
                cells[0].Record.IsSelected = true;
                cells[0].Record.IsActive = true;
            }
        }
    }
}
