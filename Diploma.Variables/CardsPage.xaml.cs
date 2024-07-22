namespace Diploma.Variables;

public partial class CardsPage : ContentPage
{

    public CardsPage()
    {
        InitializeComponent();
    }

    private void BtnRegenerateTheInbut_Clicked(object sender, EventArgs e)
    {
        TxtInput.Text = cardsContent;
    }

    private void BtnClear_Clicked(object sender, EventArgs e)
    {
        TxtOutput.Text = "";
        LblResultTitle.IsVisible = false;
        BrdOutput.IsVisible = false;
    }

    string cardsContent = "0098052999671032025/09/304789\r\n010,2012363850547,2025/09/30,4887,ALMADAR\r\n02,3374301052539,2025/09/30,5008,ALKAFA\r\n03,5910434971313,2025/09/30,1266,GIGA\r\n04,5418987057341,2025/09/30,7357,LIBYANA\r\n05,9387277195973,2025/09/30,5634,LTT\r\n06,4914309201829,2025/09/30,5276,HAWANA\r\n07,8552682039645,2025/09/30,9028,GIGA\r\n08,8851466709549,2025/09/30,7573,LIBYANA\r\n09,9359927529281,2025/09/30,7352,LTT\r\n10,4958514614432,2025/09/30,3540,GIGA\r\n11,1343254945858,2025/09/30,2624,LIBYANA\r\n12,7306501821029,2025/09/30,6430,ALMADAR\r\n13,3984216300582,2025/09/30,1905,ALKAFA\r\n14,4044627618982,2025/09/30,3178,ALKAFA\r\n15,9646950024213,2025/09/30,7429,LTT\r\n16,3444382944992,2025/09/30,6435,GIGA\r\n17,2107476693381,2025/09/30,9824,ALMADAR\r\n18,1734469366087,2025/09/30,5259,HAWANA\r\n19,4584969200571,2025/09/30,7480,HAWANA\r\n20,8105478665648,2025/09/30,3937,LIBYANA\r\n21,9062824706455,2025/09/30,1113,GIGA\r\n22,5219977088317,2025/09/30,4574,ALMADAR\r\n23,5961927600312,2025/09/30,6273,GIGA\r\n24,5765800544547,2025/09/30,5519,LIBYANA\r\n25,6909562056493,2025/09/30,8743,HAWANA\r\n26,6419018205412,2025/09/30,6797,LIBYANA\r\n27,7990209817811,2025/09/30,2272,LIBYANA\r\n28,7367148911170,2025/09/30,6171,LIBYANA\r\n29,1704788172017,2025/09/30,5652,GIGA\r\n30,1804481671405,2025/09/30,9467,LIBYANA\r\n31,7023836724708,2025/09/30,6606,LIBYANA\r\n32,3826054531498,2025/09/30,2034,LTT\r\n33,7218288933298,2025/09/30,8571,LTT\r\n34,5342896927485,2025/09/30,5585,ALMADAR\r\n35,3874950771768,2025/09/30,4178,LTT\r\n36,7931387326372,2025/09/30,2986,GIGA\r\n37,9401811866108,2025/09/30,6537,ALKAFA\r\n38,2065907820120,2025/09/30,6167,HAWANA\r\n39,3300606651866,2025/09/30,4016,GIGA\r\n40,4175461966980,2025/09/30,4693,LTT\r\n41,5691384922640,2025/09/30,6804,GIGA\r\n42,8889787096069,2025/09/30,2923,ALKAFA\r\n43,7240528523913,2025/09/30,1180,LIBYANA\r\n44,2232944847438,2025/09/30,2073,HAWANA\r\n45,2583520890884,2025/09/30,5173,ALMADAR\r\n46,6423864206894,2025/09/30,5291,GIGA\r\n47,5324860714698,2025/09/30,6869,LIBYANA\r\n48,2454378467120,2025/09/30,4364\r\n49,5568389720733,2025/09/30,3077,ALKAFA\r\n50,9415533328558,2025/09/30,4203,ALKAFA\r\n51,5162040813804,2025/09/30,6946,LTT\r\n52,2813675833407,2025/09/30,7662,ALMADAR\r\n53,7080157352730,2025/09/30,9983,HAWANA\r\n54,5341937080924,2025/09/30,5796,ALKAFA\r\n55,9122474107234,2025/09/30,8689,ALMADAR\r\n56,4239283109298,2025/09/30,8316,GIGA\r\n57,1442726501499,2025/09/30,5237,ALMADAR\r\n58,9783517818628,2025/09/30,2168,LIBYANA\r\n59,3593983727930,2025/09/30,3054,ALMADAR\r\n60,2594973934492,2025/09/30,6862,LTT\r\n61,1602458258714,2025/09/30,2879,HAWANA\r\n62,4813925993364,2025/09/30,8187,LTT\r\n63,5099794120535,2025/09/30,9511,LTT\r\n64,1684671817399,2025/09/30,4433,ALKAFA\r\n65,8735020527401,2025/09/30,7977,ALMADAR\r\n66,7318045384860,2025/09/30,6250,GIGA\r\n67,5148053359779,2025/09/30,6247,LIBYANA\r\n68,5335019966017,2025/09/30,4218,LTT\r\n69,9408520878372,2025/09/30,7795,GIGA\r\n70,3441499270856,2025/09/30,1428,HAWANA\r\n71,7376397663372,2025/09/30,5904,HAWANA\r\n72,4845169445390,2025/09/30,5557,LIBYANA\r\n73,5230485600470,2025/09/30,6043,ALMADAR\r\n74,3653395482134,2025/09/30,4080,GIGA\r\n75,4498069235544,2025/09/30,3465,HAWANA\r\n76,5559708659277,2025/09/30,4799,ALMADAR\r\n77,2533278134944,2025/09/30,9241,LIBYANA\r\n78,4652395520870,2025/09/30,9959,HAWANA\r\n79,6535782805742,2025/09/30,2985,LIBYANA\r\n80,3383085744619,2025/09/30,8368,GIGA\r\n81,8730562044411,2025/09/30,4176,ALKAFA\r\n82,7058334614531,2025/09/30,5538,LTT\r\n83,3120873928789,2025/09/30,2243,GIGA\r\n84,6775910880777,2025/09/30,7702,LTT\r\n85,8876467582693,2025/09/30,1821,GIGA\r\n86,8698876416947,2025/09/30,4321,GIGA\r\n87,6152570616594,2025/09/30,8506,GIGA\r\n88,4537597065921,2025/09/30,4917,ALKAFA\r\n89,6711176492236,2025/09/30,5052,ALKAFA\r\n90,5475625046867,2025/09/30,8673,LIBYANA\r\n91,9814717590904,2025/09/30,2847,ALKAFA\r\n92,6967564158465,2025/09/30,5278,GIGA\r\n93,5527473384846,2025/09/30,1340,LTT\r\n94,1354669055791,2025/09/30,6408,LIBYANA\r\n95,8264858787138,2025/09/30,1586,LIBYANA\r\n96,5863073899293,2025/09/30,6477,GIGA\r\n97,8315540676831,2025/09/30,7180,HAWANA\r\n98,7340030666348,2025/09/30,3883,HAWANA\r\n99,2025/09/30,7444,ALMADAR";

    private async void BtnProcess_Clicked(object sender, EventArgs e)
    {
        //التحقق اذا كان محتوئ الملف ليس فارغ
        if (cardsContent == "")
        {
            await DisplayAlert("فشل العملية", "ملف الكروت فارغ الرجاء اعادة المحاولة", "موافق");
            return;
        }
        else
        {
            //تقسم الملف بدلالة السطر الجديد [\n]
            string[] CardsArray = cardsContent.Split("\r\n");

            //اجراء عمليات علي كل سطر , والذي يمثل كرت
            foreach (var card in CardsArray)
            {
                //تقسيم السطر الي بيانات بدلالة الفاصلة [,]
                string[] cardInfo = card.Split(",");


                //التحقق من جميع الشروط مرة واحدة
                if (cardInfo.Length != 5 ||
                    cardInfo[0].Length != 2 ||
                    cardInfo[1].Length != 13 ||
                    cardInfo[3].Length != 4)
                {
                    TxtOutput.Text = TxtOutput.Text + "خطاء في الكرت المطلوب, بيانات الكرت: " + card + "\r\n";
                }

                string newFormat2 = cardInfo[1] + " - " + cardInfo[4];
                TxtOutput.Text = TxtOutput.Text + newFormat2 + "\r\n";

                //==============================================================

                //if (cardInfo.Length != 5)
                //{

                //}
                //else if (cardInfo[0].Length != 2)
                //{
                //    TxtOutput.Text = TxtOutput.Text + cardInfo[0] + "خطاء في الرقم التسلسلي" + "\r\n";
                //}
                //else if (cardInfo[1].Length != 13)
                //{
                //    TxtOutput.Text = TxtOutput.Text + cardInfo[0] + "يواجه مشكلة في عدد خانات الكرت" + "\r\n";
                //}
                //else if (cardInfo[3].Length != 4)
                //{
                //    TxtOutput.Text = TxtOutput.Text + cardInfo[0] + "PIN Code Issue" + "\r\n";
                //}
                //else
                //{
                //    string newFormat = cardInfo[1] + " - " + cardInfo[4];
                //    TxtOutput.Text = TxtOutput.Text + newFormat + "\r\n";
                //    //"\r\n" = Environment.NewLine;
                //    //"\n" = Environment.NewLine;
                //}

                //==============================================================

                //if (cardInfo.Length == 5)
                //{
                //    if (cardInfo[0].Length != 2)
                //    {
                //        TxtOutput.Text = TxtOutput.Text + cardInfo[0] + "خطاء في الرقم التسلسلي" + "\r\n";
                //    }
                //    else if (cardInfo[1].Length != 13)
                //    {
                //        TxtOutput.Text = TxtOutput.Text + cardInfo[0] + "يواجه مشكلة في عدد خانات الكرت" + "\r\n";
                //    }
                //    else if (cardInfo[3].Length != 4)
                //    {
                //        TxtOutput.Text = TxtOutput.Text + cardInfo[0] + "PIN Code Issue" + "\r\n";
                //    }
                //    else
                //    {
                //        string newFormat = cardInfo[1] + " - " + cardInfo[4];
                //        TxtOutput.Text = TxtOutput.Text + newFormat + "\r\n";
                //        //"\r\n" = Environment.NewLine;
                //        //"\n" = Environment.NewLine;
                //    }

                //}
                //else
                //{
                //    TxtOutput.Text = TxtOutput.Text + "===== كرت لا يطابق المواصفات" + "\r\n";
                //}
            }

            BrdOutput.IsVisible = true;

            LblResultTitle.IsVisible = true;

            await DisplayAlert("نجاح العملية", "تمت العملية بنجاح", "ok");
        }

    }
}




































