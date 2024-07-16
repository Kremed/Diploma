

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
            sbyte sbyteVariable = -128;

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
            float mathDegreeFloat = 1 / 3;

            // double: 64-bit double-precision floating-point, precision: ~15-16 digits
            double mathDegreeDouble = 1 / 3.0;

            // decimal: 128-bit high-precision decimal, precision: 28-29 significant digits
            decimal mathDegreeDecimal = 1 / 3.0m;

        }

        public void StringsInAction()
        {
            //Strings [السلاسل الحرفية]

            string firstName = "Al Moatasem";

            string lastName = "Kremed";

            string phoneNumber = "0924474464";

            string employeeInformation = firstName + " " + lastName + " - " + phoneNumber + " ";

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
            //// ==
            //int ageAllowed = 30;
            //int studentAge = 31;

            //// == is Equel ?
            //bool isAllowed = (studentAge == ageAllowed);

            // >
            //int ageAllowed = 30;
            //int studentAge = 32;
            //bool isAllowed = studentAge > ageAllowed;

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
    }

}
