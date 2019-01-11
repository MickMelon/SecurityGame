using SecurityGame.Constants;
using SecurityGame.Presenters;
using SecurityGame.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SecurityGame.Views
{
    public partial class QuestionManagerView : UserControl, IQuestionManagerView
    {
        public IList<string> QuestionList
        {
            get => (IList<string>)ListBox_Questions.DataSource;
            set => ListBox_Questions.DataSource = value;
        }

        public int SelectedQuestion
        {
            get => ListBox_Questions.SelectedIndex;
            set => ListBox_Questions.SelectedIndex = value;
        }

        public string Content
        {
            get => TextBox_Content.Text;
            set => TextBox_Content.Text = value;
        }

        public string CorrectAnswer
        {
            get => TextBox_CorrectAnswer.Text;
            set => TextBox_CorrectAnswer.Text = value;
        }

        public string WrongAnswer
        {
            get => TextBox_WrongAnswer.Text;
            set => TextBox_WrongAnswer.Text = value;
        }

        public int CorrectVirusChange
        {
            get => (int)UpDown_CorrectVirus.Value;
            set => UpDown_CorrectVirus.Value = value;
        }

        public int CorrectReputationChange
        {
            get => (int)UpDown_CorrectRep.Value;
            set => UpDown_CorrectRep.Value = value;
        }

        public int WrongVirusChange
        {
            get => (int)UpDown_WrongVirus.Value;
            set => UpDown_WrongVirus.Value = value;
        }

        public int WrongReputationChange
        {
            get => (int)UpDown_WrongRep.Value;
            set => UpDown_WrongRep.Value = value;
        }

        public AdminPresenter Presenter { set; private get; }

        private bool _isEditMode = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionManagerView"/> class.
        /// </summary>
        public QuestionManagerView()
        {
            InitializeComponent();
            SetFieldsEditableStatus();
        }

        /// <summary>
        /// Sets the read only values of the fields depending on
        /// whether it is in edit mode.
        /// </summary>
        private void SetFieldsEditableStatus()
        {
            TextBox_Content.ReadOnly = !_isEditMode;
            TextBox_CorrectAnswer.ReadOnly = !_isEditMode;
            TextBox_WrongAnswer.ReadOnly = !_isEditMode;

            UpDown_CorrectRep.ReadOnly = !_isEditMode;
            UpDown_CorrectVirus.ReadOnly = !_isEditMode;
            UpDown_WrongRep.ReadOnly = !_isEditMode;
            UpDown_WrongVirus.ReadOnly = !_isEditMode;

            UpDown_CorrectRep.Increment = _isEditMode ? 1 : 0;
            UpDown_CorrectVirus.Increment = _isEditMode ? 1 : 0;
            UpDown_WrongRep.Increment = _isEditMode ? 1 : 0;
            UpDown_WrongVirus.Increment = _isEditMode ? 1 : 0;

            Button_EditSave.Text = _isEditMode ? "Save" : "Edit";
            Button_Cancel.Enabled = _isEditMode;
        }

        /// <summary>
        /// Set whether the edit or delete buttons should be 
        /// disabled. Used when there are no questions in the
        /// database to prevent errors.
        /// </summary>
        /// <param name="enabled">Whether the buttons should be enabled.</param>
        private void SetEditDeleteButtonsEnabled(bool enabled)
        {
            _isEditMode = enabled;
            SetFieldsEditableStatus();

            Button_Delete.Enabled = enabled;
            Button_EditSave.Enabled = enabled;
            Button_Cancel.Enabled = enabled;
        }

        /// <summary>
        /// Checks if there are any questions in the database.
        /// </summary>
        /// <returns>Whether there are questions in the database.</returns>
        private bool AreQuestions()
        {
            var list = (List<string>)ListBox_Questions.DataSource;
            return !list[0].Equals(Messages.NO_QUESTIONS);
        }

        /// <summary>
        /// Called when the user clicks the Edit/Save button.
        /// </summary>
        private void Button_EditSave_Click(object sender, EventArgs e)
        {
            if (!AreQuestions())
            {
                SetEditDeleteButtonsEnabled(false);
                return;
            }
            Presenter.SaveQuestion();
            Presenter.UpdateQuestionView();
            Presenter.UpdateQuestionListView();
            _isEditMode = !_isEditMode;
            SetFieldsEditableStatus();
        }

        /// <summary>
        /// Called when the user clicks the Back button.
        /// </summary>
        private void Button_Back_Click(object sender, EventArgs e)
        {
            Presenter.ShowAdmin();
        }

        /// <summary>
        /// Called when the user clicks the Cancel button.
        /// </summary>
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            if (!AreQuestions())
            {
                SetEditDeleteButtonsEnabled(false);
                return;
            }

            _isEditMode = !_isEditMode;
            SetFieldsEditableStatus();
            Presenter.UpdateQuestionView();
        }

        /// <summary>
        /// Called when the user clicks the Add button.
        /// </summary>
        private void Button_Add_Click(object sender, EventArgs e)
        {
            Presenter.AddQuestion();
            Presenter.UpdateQuestionListView();
            SetEditDeleteButtonsEnabled(true);
        }

        /// <summary>
        /// Called when the user clicks the Delete button.
        /// </summary>
        private void Button_Delete_Click(object sender, EventArgs e)
        {           
            if (!AreQuestions())
            {
                SetEditDeleteButtonsEnabled(false);
                return;
            }

            var result = MessageBox.Show(
                "Are you sure you want to delete this question? This action cannot be undone!",
                "Delete Question?",
                MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                Presenter.DeleteQuestion();
            }
        }

        /// <summary>
        /// Called when the user clicks a new question in the list.
        /// </summary>
        private void ListBox_Questions_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presenter.UpdateQuestionView();
        }
    }
}
