namespace Diploma.Variables
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

        }

        public void IntegerInAction()
        {
            //integer [الارقام الصحيحة]


            //byte: 8 - bit unsigned integer, range: 0 to 255
            byte byteVariable = 255;

            //sbyte: 8 - bit signed integer, range: -128 to 127
            sbyte sbyteVariable = -3;

            //ushort: 16 - bit unsigned integer, range: 0 to 65,535
            ushort ushortVariable = 65535;

            //short: 16 - bit signed integer, range: -32,768 to 32,767
            short shortVariable = -32768;

            //uint: 32 - bit unsigned integer, range: 0 to 4,294,967,295
            uint uintVariable = 4294967295;

            //int: 32 - bit signed integer, range: -2,147,483,648 to 2,147,483,647
            int intVariable = -2147483648;

            //long: 64 - bit signed integer, range: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            long longVariable = -9223372036854775808;

            //ulong: 64 - bit unsigned integer, range: 0 to 18,446,744,073,709,551,615
            ulong ulongVariable = 18446744073709551615;

        }

        public void FlotingPointInAction()
        {
            //floating-point [الارقام العشرية]

            // float: 32-bit single-precision floating-point, precision: ~7 digits
            float mathDegreeFloat = 5.25f;

            // double: 64-bit double-precision floating-point, precision: ~15-16 digits
            double mathDegreeDouble = 5.5;

            // decimal: 128-bit high-precision decimal, precision: 28-29 significant digits
            decimal mathDegreeDecimal = 5.25m;

        }

        public void StringsInAction()
        {

            //Strings [السلاسل الحرفية]

            string firstName = "Al Moatasem";

            string lastName = "Kremed";

            string phoneNumber = "0924474464";

            string fullName = "Hi Mr. " + firstName + " " + lastName + " - " + phoneNumber;

            string fullName2 = $"Hi Mr. {firstName} {lastName} - Your Phone Number is : {phoneNumber}";

            string name = $"{firstName} {lastName} - {phoneNumber}";
        }

        public void BooleanInAction()
        {
            // bool: Boolean type, represents true or false, occupies 1 byte
            bool isVip = true; // true = 1

            bool isPaid = false; // false = 0
        }

        public void Operations()
        {
            // ==
            //int ageAllowed = 30;
            //int studentAge = 31;

            ////// == is Equel ?
            //bool isAllowed = (studentAge == ageAllowed);

            // >
            //int ageAllowed = 30;
            //int studentAge = 30;
            //bool isAllowed = studentAge >= ageAllowed;

            // <
            int ageAllowed = 30;
            int studentAge = 30;
            bool isAllowed = ageAllowed <= studentAge;

            //bool isAllowed = studentAge > ageAllowed;
            //bool isAllowed2 = studentAge >= ageAllowed;
        }

        private void SetTheFullName(object sender, EventArgs e)
        {

            //string firstName = TxtFirstName.Text;

            //string lastName = TxtLastName.Text;

            //string fullName = firstName + " " + lastName;

            //LblFullName.Text = fullName;

            LblFullName.Text = TxtFirstName.Text + " " + TxtLastName.Text;
        }

        public void ArrayInAction()
        {
            int[] phoneNumbers = new int[8];
            phoneNumbers[0] = 0924474464;
            phoneNumbers[7] = 0924474464;

            string[] studentNames = new string[10];
            studentNames[0] = "Rami";
            studentNames[1] = "Elias";
            studentNames[2] = "Mahmoud";
            studentNames[3] = "أنس";
            studentNames[4] = "ســالم";
            studentNames[5] = "محمود";
            studentNames[6] = "أحمد";
            studentNames[7] = "المعتصم";
            //studentNames[10] = "Null Ex";

            string[] studentNames2 = {
                "Rami",
                "Elias",
                "Mahmoud",
                "أنس",
                "ســالم",
                "محمود",
                "أحمد",
                "المعتصم",
                "المعتصم",
                  "أنس",
                "ســالم",
                "محمود",
                "أحمد",
                  "أنس",
                "ســالم",
                "محمود",
                "أحمد",
                  "أنس",
                "ســالم",
                "محمود",
                "أحمد",
                  "أنس",
                "ســالم",
                "محمود",
                "أحمد",
            };


            var arrayCount = studentNames2.Length;

        }

        public void WorkWithStringExpressions()
        {
            string greeting = "Hallo, World!";

            int length = greeting.Length;

            char firstChar = greeting[0];

            string LibyanaCard = "Your Card Pin Is : 9843209432843209843243843298432432";

            LibyanaCard = LibyanaCard.Substring(19, (LibyanaCard.Length - 19));

            string sub = greeting.Substring(7, 2);

            string upper = greeting.ToUpper();

            string lower = greeting.ToLower();

            string trimmed = greeting.Trim();

            bool containsCSharp = greeting.Contains("@");

            string replaced = greeting.Replace("World", "Moatasem Kremed");

            string fruits = "apple banana orange";

            string[] fruitArray = fruits.Split(' ');

            string anothetfruits = string.Join(" ", fruitArray);


            string[] words = { "C#", "is", "awesome" };
            string sentence = string.Join(" ", words);  // sentence = "C# is awesome"
        }

        public void WorkWithArrayExpressions()
        {
            string[] studentNames = new string[8] {
                "Rami",
                "Elias",
                "Mahmoud",
                "أنس",
                "ســالم",
                "محمود",
                "أحمد",
                "المعتصم"
            };

            //01 - Length : هو خاصية تُستخدم للحصول على عدد العناصر الموجودة في المصفوفة.

            //02 - Index  : هو موضع عنصر معين في المصفوفة أو أي نوع آخر من المجموعات .
            //         يبدأ العد في معظم لغات البرمجة، بما في ذلك سي شارب، من 0.

            int length = studentNames.Length;  // 8

            Array.Sort(studentNames);  // فرز المصفوفة تصاعديًا

            Array.Reverse(studentNames); // عكس ترتيب المصفوفة

            int index = Array.IndexOf(studentNames, "أنس");  // البحث عن موقع الرقم 3 في المصفوفة

            string[] numbersCopy = new string[studentNames.Length]; // Copy
            Array.Copy(studentNames, numbersCopy, studentNames.Length);
        }

        public void WorkWithMathLibrary()
        {
            int sum = 5 + 3;  //  الجمع او الاجمالي Addition (+)

            int difference = 5 - 3;  //  الفرق او الطرح Subtraction (-)

            int product = 5 * 3;  //  الضرب 

            int quotient = 6 / 3;  // القسمة

            int remainder = 5 % 3;  //  (٪) للعثور على باقي القسمة


            double power = Math.Pow(2, 3);  // الأس = 2×2×2 = 8

            double squareRoot = Math.Sqrt(16); // Math.Sqrt

            double roundedValue = Math.Round(3.75);  // التقريب

            //الدوال المثلثية (Trigonometric Functions) =>

            double cosine = Math.Cos(45);  // Cosine
            double sine = Math.Sin(45);  // Sine 
            double tangent = Math.Tan(45);  // Tangent 
        }

        public void HomeWork()
        {
            string[] Cars = {
                "مارسيدس",
                "بي ام دبليو",
                "! ميتشوبيستي !",
                "تـايوتا",
                "! بــورش !"
            };

            //01 - Finde the Index For "تـايوتا" :
            int index = Array.IndexOf(Cars, "تـايوتا");
            //02 - Via code get the Length of Cars Array :
            int length = Cars.Length;
            //03 - set all Array Elements in string, and remove [!] from this string

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //IterationStatments();
            SelectionStatments();
        }

        public async void SelectionStatments()
        {
            //    string phoneNumber = "0924474464";
            //    string phoneNumber2 = "+218924474464";

            //    //if (phoneNumber.StartsWith("+218") && 
            //    //    phoneNumber.Contains("09") && 
            //    //    phoneNumber.Length == 13 )
            //    //{

            //    //}


            //    int StudentMark = 105;

            //    if (StudentMark < 50 && StudentMark > 0)
            //    {
            //        await DisplayAlert("النتيجة", "راسب", "OK");
            //    }
            //    else if (StudentMark >= 50 && StudentMark < 65 )
            //    {
            //        await DisplayAlert("النتيجة", "مقبةل", "OK");
            //    }
            //    else if (StudentMark >= 65 && StudentMark < 75)
            //    {
            //        await DisplayAlert("النتيجة", "جيد", "OK");
            //    }
            //    else if (StudentMark >= 75 && StudentMark < 85)
            //    {
            //        await DisplayAlert("النتيجة", "جيد جدا", "OK");
            //    }
            //    else if (StudentMark >= 85 && StudentMark < 100)
            //    {
            //        await DisplayAlert("النتيجة", "ممتاز", "OK");
            //    }
            //    else
            //    {
            //        await DisplayAlert("النتيجة", "ادخال خاطئ, الرجاء التأكيد من الدرجة", "OK");
            //    }



            //    int walletBalance = 700;
            //    int ItemPrice = 800;


            //    if (walletBalance > ItemPrice)
            //    {
            //        await DisplayAlert($"معاملة ناجحة", $"سيتم خصم قيمة اشتراكك في الباقة بسعر {ItemPrice} من رصيد محفظتك : {walletBalance}", "موافق");
            //    }
            //    else
            //    {
            //        await DisplayAlert($"معاملة ملغية", $"لايوجد لديك رصيد كافي, الرجاء اعادة شحن المحفظة من أقرب نقطة شحن.", "موافق");
            //    }


            //    int ageAllowed = 30;
            //    int studentAge = 31;
            //    if (studentAge > ageAllowed)
            //    {
            //        await DisplayAlert($"التسجيل مسموح", $"نعم عمرالطالب هوا {studentAge} اكبر من العمر المسموح به {ageAllowed}", "OK");
            //    }

            //    //======================================

            //    var studentMark = 70;


            //    if (studentMark < 50)
            //    {
            //        await DisplayAlert($"نتيجة الامتحان", $"تقديرك هوا : راسب", "OK");
            //    }
            //    else if (studentMark <= 65)
            //    {
            //        await DisplayAlert($"نتيجة الامتحان", $"تقديرك هوا :{studentMark} مقبــول", "OK");
            //    }
            //    else if (studentMark <= 75)
            //    {
            //        await DisplayAlert($"نتيجة الامتحان", $"تقديرك هوا : جيد", "OK");
            //    }
            //    else if (studentMark <= 85)
            //    {
            //        await DisplayAlert($"نتيجة الامتحان", $"تقديرك هوا : جيد جـداٌ", "OK");
            //    }
            //    else
            //    {
            //        await DisplayAlert($"نتيجة الامتحان", $"تقديرك هوا : ممتـــاز", "OK");
            //    }









            float LYDUSD = 6.95f;
            float LYDEUR = 7.48f;
            float LYDGBP = 8.61f;
            float LYDTUN = 2.17f;

            float ExchangeCurrencyAmount;
            // كمية سعر صرف العملة

           
            float LibyanDinarAmount = 3450;
            string CurrencyName = "EUR";

            if (CurrencyName == "USD")
                ExchangeCurrencyAmount = LibyanDinarAmount / LYDUSD;
            else if (CurrencyName == "EUR")
                ExchangeCurrencyAmount = LibyanDinarAmount / LYDEUR;
            else if (CurrencyName == "GBP")
                ExchangeCurrencyAmount = LibyanDinarAmount / LYDGBP;
            else if (CurrencyName == "TUN")
                ExchangeCurrencyAmount = LibyanDinarAmount / LYDTUN;
            else
            {
                ExchangeCurrencyAmount = 0;
                await DisplayAlert("نتيجة المعاملة",
                "لانملك خيار تصريف نوع العملة" + CurrencyName,
                "موافق");
                return;
            }

            await DisplayAlert("نتيجة المعاملة",
                "من صرف : " + LibyanDinarAmount + " LYD " + "ستتحصل علي " + ExchangeCurrencyAmount + " " + CurrencyName,
                "موافق");












            switch (CurrencyName)
            {
                case "USD":
                    ExchangeCurrencyAmount = LibyanDinarAmount / LYDUSD;
                    break;

                case "EUR":
                    ExchangeCurrencyAmount = LibyanDinarAmount / LYDEUR;
                    break;

                case "GBP":
                    ExchangeCurrencyAmount = LibyanDinarAmount / LYDGBP;
                    break;

                case "TUN":
                    ExchangeCurrencyAmount = LibyanDinarAmount / LYDTUN;
                    break;

                default:
                    break;
            }
            await DisplayAlert("نتيجة المعاملة",
                "من صرف : " + LibyanDinarAmount + " LYD " + "ستتحصل علي " + ExchangeCurrencyAmount + " " + CurrencyName,
                "موافق");
        }

       
    }

}
