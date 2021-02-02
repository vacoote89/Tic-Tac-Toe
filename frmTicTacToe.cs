using System;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class frmTicTacToe : Form
    {
        
        public frmTicTacToe()
        {
            InitializeComponent();
           
        }

        /**
         * Generic method to handle the button click event for any square
         * @param sender Object The Control that was clicked (in this case a button)
         * @param e EventArgs Standard event arguments captured
         */ 
        private void clickHandler(Object sender,EventArgs e)
        {
            //Hint: to get the row and column of the button clicked, use the GetRow/GetColumn methods of the TableLayoutPanel
        }

     
    }
}
