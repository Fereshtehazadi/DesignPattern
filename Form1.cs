using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPattern
{
    public partial class Form1 : Form
    {
        DisplayText display;
        Caretaker caretaker;
        public Form1()
        {
 
            InitializeComponent();

            display = new DisplayText("Welcome");
            caretaker = new Caretaker(display);

            lblDisplayText.Text = display._Text;

            HandleTextChanged();
        }

             
        private void btAdd_Click(object sender, EventArgs e)
        {
            caretaker.Backup();

            int addPosition = (int) nAddPosition.Value;
            string textToAdd = tbAddText.Text;
            lblDisplayText.Text = display.Add(addPosition, textToAdd);

            HandleTextChanged();
        }

        private void btReplace_Click(object sender, EventArgs e)
        {
            caretaker.Backup();

            string replaceFrom = tbReplaceFrom.Text;
            string replaceTo = tbReplaceTo.Text;
          
            lblDisplayText.Text = display.Replace(replaceFrom, replaceTo);
            HandleTextChanged();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            caretaker.Backup();

            int removeFrom = (int) nRemoveFrom.Value;
            int removeTo = (int)nRemoveTo.Value;
         
            lblDisplayText.Text = display.Remove(removeFrom, removeTo);
            HandleTextChanged();
        }

        private void btUndo_Click(object sender, EventArgs e)
        {
            caretaker.Undo();
            lblDisplayText.Text = display._Text;
            HandleTextChanged();
        }

        private void btRedo_Click(object sender, EventArgs e)
        {
            caretaker.Redo();
            lblDisplayText.Text = display._Text;
            HandleTextChanged();
        }

        private void HandleTextChanged()
        {
            btUndo.Enabled = caretaker.EnableUndo();
            btRedo.Enabled = caretaker.EnableRedo();

            nAddPosition.Maximum = display._Text.Length;
            nRemoveFrom.Maximum = display._Text.Length;
            nRemoveTo.Maximum = display._Text.Length;
          
        }
    }   
}
