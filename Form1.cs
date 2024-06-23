using System;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace _79_NguyenVietKham_BaoCao_KTPM
{
    public partial class Form1 : Form
    {

        //79_NguyenVietKham
        private IWebDriver driver_79;
        private const string siteURL = "https://imgur.com/";
        private const string webSignIn = "https://imgur.com/signin?redirect=https%3A%2F%2Fimgur.com%2F";

        private void chromeconsole()
        {
            //79_NguyenVietKham

        var options = new ChromeOptions();
            //cấu hình chromeversion
        options.AddArgument("profile-directory=Default");
        options.AddArgument("--start-maximized");
        var service = ChromeDriverService.CreateDefaultService();
        service.HideCommandPromptWindow = true;
        driver_79 = new ChromeDriver(service, options);
        }


        public Form1()
        {         
            //79_NguyenVietKham
            InitializeComponent();
            chromeconsole();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //hàm thực hiện Unit Test tính BMI 
        private void btnTinh_79_kham_Click(object sender, EventArgs e)
        {
            ////79_NguyenVietKham
            //double height, weight, results;
            //height = double.Parse(txtCanNang.Text);
            //weight = double.Parse(txtChieuCao.Text);
            //CaculationBMI_77_NguyenVietKham solve = new CaculationBMI_77_NguyenVietKham(height, weight);
            //results = solve.CalculateBMI_77_Kham(height, weight);
            //txtKetQua.Text = results.ToString();
        }




        // Phương thức điều hướng tới trang web sẽ kiểm thử
        private void Open_LinkURL()
        {
            //79_NguyenVietKham
            driver_79.Navigate().GoToUrl(siteURL);

        }

        // Phương thức điều hướng tới trang web đăng nhập
        private void Open_LinkSignIn()
        {
            //79_NguyenVietKham
            driver_79.Navigate().GoToUrl(webSignIn);

        }


        private void ClickCreateNewPost()
        {
            //79_NguyenVietKham
            driver_79.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[4]/div[3]/a")).Click();
            Thread.Sleep(2000);
        }

        //-------- 2 phương thức Check Ảnh & Video----------

        // Check lỗi định dạng ảnh / video
        private void checkType_79_kham(int testNum)
        {
            var message = driver_79.FindElement(By.ClassName("UploadError-text"));

            if (message.Text == "Sorry, you can't upload that type of file.")
                listBoxTC.Items.Add("Test Case " + testNum + " failed");
            else
                listBoxTC.Items.Add("Test Case " + testNum + " pass");
        }
        // Check lỗi vượt dung lượng hình ảnh/ vidoe
        private void checkSize_79_kham(int testNum)
        {
            var message = driver_79.FindElement(By.ClassName("UploadError-text"));

            if (message.Text == "Woah there! Your file is too large.")
                listBoxTC.Items.Add("Test Case " + testNum + " failed");
            else
                listBoxTC.Items.Add("Test Case " + testNum + " pass");
        }

        private void checkTypePic_79_kham(int testNum)
        {
            var textMessage = driver_79.FindElement(By.CssSelector("#root > div > div.desktop-app.App >" +
                " div > div.Upload-container > div.UploadPost > div > div.PostContent.UploadPost-file > div.PostContent-loadError > div"));

            if (textMessage.Text == "We don't support that file type!")
                listBoxTC.Items.Add("Test Case " + testNum + " failed");
            else
                listBoxTC.Items.Add("Test Case " + testNum + " pass");
        }

        // Tổ hợp phương thức test case 

        private void TestErrorTypePic()
        {
            //79_NguyenVietKham
            driver_79.FindElement(By.CssSelector("input[type='file']")).SendKeys(@"E:\testimgur\WrongTypePic.WEBP");
            Thread.Sleep(2000);
        }

        private void TestErrorOversizePic()
        {
            //79_NguyenVietKham
            driver_79.FindElement(By.CssSelector("input[type='file']")).SendKeys(@"E:\testimgur\OverSizePic.PNG");
            Thread.Sleep(2000);
        }
        private void TestErrorTypeVideo()
        {
            //79_NguyenVietKham
            driver_79.FindElement(By.CssSelector("input[type='file']")).SendKeys(@"E:\testimgur\ErrorTypeVideo.VOB");
            Thread.Sleep(2000);
        }

        private void TestErrorOversizeVideo()
        {
            //79_NguyenVietKham
            driver_79.FindElement(By.CssSelector("input[type='file']")).SendKeys(@"E:\testimgur\ErrorOversizeVideo.WEBM");
            Thread.Sleep(2000);
        }

        private void TestUploadSucceed()
        {
            //79_NguyenVietKham
            driver_79.FindElement(By.CssSelector("input[type='file']")).SendKeys(@"E:\testimgur\testImgur.JPG");
            driver_79.FindElement(By.CssSelector("input[type='file']")).SendKeys(@"E:\testimgur\UpSuceedVideo.MP4");
            Thread.Sleep(2000);
            driver_79.FindElement(By.XPath("/html/body/div/div/div[1]/div/div[5]/div[2]/div/div[5]/div/div/div[3]/button[2]")).Click();
            Thread.Sleep(2000);
        }

        //--------Test case Login------

        private void WrongGmail()
        {
            driver_79.FindElement(By.CssSelector("#username")).SendKeys("hulk01696398026com");
            driver_79.FindElement(By.CssSelector("#password")).SendKeys("kham1204.");
            Thread.Sleep(2000);
            driver_79.FindElement(By.XPath("/html/body/div[4]/div[3]/form/div[2]/button")).Click();
            Thread.Sleep(2000);

            
        }

        private void WrongCaptcha()
        {
            driver_79.FindElement(By.CssSelector("#username")).SendKeys("hulk01696398026@gmailcom");
            driver_79.FindElement(By.CssSelector("#password")).SendKeys("kham1204.");
            Thread.Sleep(2000);

            driver_79.FindElement(By.CssSelector("#recaptcha-anchor > div.recaptcha-checkbox-border")).Click();
            Thread.Sleep(2000);

            driver_79.FindElement(By.XPath("/html/body/div[4]/div[3]/form/div[2]/button")).Click();
            Thread.Sleep(2000);

        }




        //--------- Viết phương thức xử lí các button--------


        // Tải ảnh thành công
        private void btnGoToImgur_79_kham_Click(object sender, EventArgs e)
        {
            //79_VietKham
            Open_LinkURL();
            Thread.Sleep(2000);
            //Click vào nút New Post
            ClickCreateNewPost();
            // Đưa đường dẫn hình ảnh và video thõa điều kiện 
            TestUploadSucceed();
            //Nhập tiêu đề hình ảnh
            driver_79.FindElement(By.ClassName("UploadPost-editable")).SendKeys("Outstanding!");
            Thread.Sleep(2000);
            // Nhập mô tả 
            driver_79.FindElement(By.ClassName("ImageDescription-editable")).SendKeys("Chemistry");
            Thread.Sleep(2000);

        }


        // Viết đoạn code thực thi sự kiện Click cho nút Đăng ảnh sai địng dạng
        private void btnErrorTypePic_79_kham_Click(object sender, EventArgs e)
        {
            Open_LinkURL();
            ClickCreateNewPost();
            TestErrorTypePic();
            Thread.Sleep(3000);
            checkTypePic_79_kham(1);

        }

        // Viết đoạn code thực thi sự kiện Click cho nút Đăng ảnh sai vượt quá dung lượng
        private void btnErrorSizePic_79_kham_Click(object sender, EventArgs e)
        {
            Open_LinkURL();
            ClickCreateNewPost();
            TestErrorOversizePic();
            checkSize_79_kham(2);

        }


        // Viết đoạn code thực thi sự kiện Click cho nút Đăng video sai định dạng
        private void btnErrorTypeVid_79_kham_Click(object sender, EventArgs e)
        {
            Open_LinkURL();
            ClickCreateNewPost();
            TestErrorTypeVideo();
            checkType_79_kham(3);
        }

        // Viết đoạn code thực thi sự kiện Click cho nút Đăng video vượt quá dung lượng

        private void btnErrorSizeVideo_77_kham_Click(object sender, EventArgs e)
        {
            Open_LinkURL();
            ClickCreateNewPost();
            TestErrorOversizeVideo();
            checkSize_79_kham(4);
        }

        private void btnSignUp79Kham_Click(object sender, EventArgs e)
        {
            Open_LinkSignIn();
            WrongGmail();
            Thread.Sleep(2000);
            WrongCaptcha();
        }
    }
}
