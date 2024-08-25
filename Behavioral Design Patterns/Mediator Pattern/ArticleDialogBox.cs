using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mediator_Pattern
{
    // Mediator Class
    public class ArticleDialogBox : DialogBox   
    {
        private ListBox articleListBox;
        private TextBox titleTextBox;
        private Button saveButton;

        public ArticleDialogBox(ListBox listBox, TextBox textBox, Button button)
        {
            this.articleListBox = listBox;
            articleListBox.setOwner(this);

            this.titleTextBox = textBox;
            titleTextBox.setOwner(this);

            this.saveButton = button;
            saveButton.setOwner(this);
        }

        public void simulateUserInteraction() 
        {
            articleListBox.setSelection("Article 1");
            titleTextBox.setContent("hello, World!");
            Console.WriteLine($"TextBox: {titleTextBox.getContent()}");
            Console.WriteLine($"Button: {saveButton.getEnabled()}");
        }

        public void changed(UIControl control)
        {
            if (control == articleListBox)
                articleSelected();
            else if (control == titleTextBox)
                titleChanged();
        }

        private void titleChanged()
        {
            var content = titleTextBox.getContent();
            var isEmpty = (string.IsNullOrEmpty(content));
            saveButton.setEnabled(!isEmpty);

        }

        private void articleSelected() 
        {
            titleTextBox.setContent(articleListBox.getSelection());
            saveButton.setEnabled(true);
        }
    }
}
