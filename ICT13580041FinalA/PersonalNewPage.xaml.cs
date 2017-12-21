using System;
using System.Collections.Generic;
using ICT13580041FinalA.Models;
using Xamarin.Forms;

namespace ICT13580041FinalA
{
    public partial class PersonalNewPage : ContentPage
    {
        Product product;
        public PersonalNewPage(Product product=null)
        {


            InitializeComponent();

            this.product = product;
            titleLabel.Text = product == null ? "เพิ่มข้อมูลใหม่" : "แก้ไขข้อมูล";

            saveButton.Clicked += SaveButton_Clicked;
            cancelButton.Clicked += CancelButton_Clicked;
            sunStepper.ValueChanged += SunStepper_ValueChanged;
            salarySlider.ValueChanged += SalarySlider_ValueChanged;



            saxPicker.Items.Add("ชาย");
            saxPicker.Items.Add("หญิง");

            partPicker.Items.Add("ช่างซ่อม");
            partPicker.Items.Add("การเงิน");
            partPicker.Items.Add("ทรัพยากรบุคคล");


           




            if(product != null)
            {
                nameEntry.Text = product.Name;
                lastNameEntry.Text = product.LastName;
                ageEntry.Text = product.Age.ToString();


                phoneEntry.Text = product.Phone.ToString();
                emailEntry.Text = product.Email;
                addressEditor.Text = product.Address;


            }
        }

        void SalarySlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double value = (int)e.NewValue;

        }

        void SunStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
        }

        async    void SaveButton_Clicked(object sender, EventArgs e)
        {
            var isOk = await DisplayAlert("ยืนยัน", "คุณต้องการบันทึกใช่หรือไม่", "ใช่", "ไม่ใช่");
            if (isOk)
            {
                if(product == null)
                {
                    product = new Product();
                    product.Name = nameEntry.Text;
                    product.LastName = lastNameEntry.Text;
                    product.Age = int.Parse(ageEntry.Text);
                    product.Phone = int.Parse(phoneEntry.Text);
                    product.Email = emailEntry.Text;
                    product.Address = addressEditor.Text;

                }
                else
                {
					product.Name = nameEntry.Text;
					product.LastName = lastNameEntry.Text;
					product.Age = int.Parse(ageEntry.Text);
					product.Phone = int.Parse(phoneEntry.Text);
					product.Email = emailEntry.Text;
					product.Address = addressEditor.Text;



                }

                await Navigation.PopModalAsync();

            }
        }

        async  void CancelButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
