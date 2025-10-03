namespace Management_Users;

public class FormNavigator
{
    public static void Navigate(Form currentForm, Form nextForm)
    {
        currentForm.Hide();      
        nextForm.Show();        
        currentForm.Hide();     
    }
    
    public static void NavigateModal(Form currentForm, Form nextForm)
    {
        currentForm.Hide();
        nextForm.ShowDialog();
        currentForm.Hide();
    }
}