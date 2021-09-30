using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsUI
{
    public class SearchWindow
    {
        Button clearButton = new Button();
        TextBox searchBox = new TextBox();

        public SearchWindow()
        {
            Action action = new Action(this.ClearButton_Clicked);
            this.clearButton.Click += action;
        }

        public void SimulateClearButtonClick()
        {
            clearButton.OnClick();
        }

        private void ClearButton_Clicked()
        {
            searchBox.Clear();
        }
    }
}
