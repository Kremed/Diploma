namespace Diploma.Variables;

public partial class CalculatorPage : ContentPage
{
    public CalculatorPage()
    {
        InitializeComponent();
    }

    private async void BtnCalculat_Clicked(object sender, EventArgs e)
    {

        var result = TxtFirstNumber.Text + TxtSecondNumber;
    }
}






























//int resultIntager;
//bool isIntNumber= int.TryParse(result, out resultIntager);

//if (isIntNumber)
//{
//    await DisplayAlert($"", $"{resultIntager}", "موافق");
//}
//else
//{
//    await DisplayAlert($"", $"لم تتم عملية تحويل النص الي رقم", "موافق");
//}