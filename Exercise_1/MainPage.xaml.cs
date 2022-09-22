using System.Text;

namespace Exercise_1;

public partial class MainPage : ContentPage
{
	int count = 0;
	string myText = "";
	string[] vowels = { "a", "e", "i", "o", "u" };

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnTextChanged(object sender, EventArgs e)
    {
		myText = alphabet.Text;
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
        
		var lowerCaseText = myText.ToLower();

        //StringBuilder builder = new StringBuilder();

        if (vowels.Contains(lowerCaseText))
        {
            vowelButton.Text = $"Vowel";
        } else
        {
            vowelButton.Text = $"not a vowel";
        }
    }

 //   private void OnCounterClicked(object sender, EventArgs e)
	//{
	//	count++;

	//	if (count == 1)
	//		CounterBtn.Text = $"Clicked {count} time";
	//	else
	//		CounterBtn.Text = $"Clicked {count} times";

	//	SemanticScreenReader.Announce(CounterBtn.Text);
	//}
}


