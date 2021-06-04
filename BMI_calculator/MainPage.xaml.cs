using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMI_calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        double calories_m = 0;
        double calories_w;

        double age;
        int selected;
        double hight;
        double weight;



        public void OnEntryTextChanged(object sender, EventArgs e)
        {

            double result = 0D;


            selected = Gender.SelectedIndex;
            if (selected == 0)
            {
                BMI_result.Text = $"Your BMI is {result:0}";
                slika.Source = ImageSource.FromFile("picture1.png");
                CaloriesPD.Text = "Enter\n parameters!!!";
                Message.Text = "You are Perfect";
            }
            if (selected == 1)
            {
                BMI_result.Text = $"Your BMI is {result:0}";
                slika.Source = ImageSource.FromFile("picture2.png");
                CaloriesPD.Text = "Enter\n parameters!!!";
                Message.Text = "You are Perfect";
            }
            else
            {
                CaloriesPD.Text = "Enter\n parameters!!!";
            }


            if (double.TryParse(EntryHight.Text, out hight) && double.TryParse(EntryWeight.Text, out weight) && double.TryParse(Age.Text, out age))
            {
                {
                    if ((button_cm).IsChecked && (button_kg).IsChecked && hight != 0)
                    {
                        result = weight / (hight * hight / 10000);
                        calories_m = (88.362 + (13.397 * weight) + (4.799 * hight) - (5.677 * age));
                        calories_w = (447.593 + (9.247 * weight) + (3.098 * hight) - (4.330 * age));

                    }
                    else if ((button_in).IsChecked && (button_lbs).IsChecked && hight != 0)
                    {
                        hight *= 2.54;
                        weight *= 0.454;
                        result = (weight / (hight * hight / 10000));
                        calories_m = (88.362 + (13.397 * weight) + (4.799 * hight) - (5.677 * age));
                        calories_w = (447.593 + (9.247 * weight) + (3.098 * hight) - (4.330 * age));


                    }

                    else if ((button_in).IsChecked && (button_kg).IsChecked && hight != 0)
                    {
                        hight *= 2.54;
                        result = weight / (hight * hight / 10000);
                        calories_m = (88.362 + (13.397 * weight) + (4.799 * hight) - (5.677 * age));
                        calories_w = (447.593 + (9.247 * weight) + (3.098 * hight) - (4.330 * age));


                    }
                    else if ((button_cm).IsChecked && (button_lbs).IsChecked && hight != 0)
                    {
                        weight *= 0.454;
                        result = weight / (hight * hight / 10000);
                        calories_m = (88.362 + (13.397 * weight) + (4.799 * hight) - (5.677 * age));
                        calories_w = (447.593 + (9.247 * weight) + (3.098 * hight) - (4.330 * age));


                    }
                    else
                    {
                        BMI_result.Text = $"BMI";
                    }
                    BMI_result.Text = $"Your BMI is {result:0.00}";



                    if (selected == 0)
                    {

                        CaloriesPD.Text = $"Calories per day {calories_m:0.00}!!";
                        



                        if (result > 0 && result < 18.5)
                        {
                            slika.Source = ImageSource.FromFile("muskarac1");
                            Message.Text = "Underweight!";
                        }
                        else if (result >= 18.5 && result < 25)
                        {
                            slika.Source = ImageSource.FromFile("muskarac2");
                            Message.Text = "Normal!";
                        }
                        else if (result >= 25 && result < 30)
                        {
                            slika.Source = ImageSource.FromFile("muskarac3");
                            Message.Text = "Overweight!";
                        }
                        else if (result >= 30 && result < 35)
                        {
                            slika.Source = ImageSource.FromFile("muskarac4");
                            Message.Text = "Obese!";
                        }
                        else if (result >= 35)
                        {
                            slika.Source = ImageSource.FromFile("muskarac5");
                            Message.Text = "Extremly Obese!";
                        }
                    }

                    if (selected == 1)
                    {
                        CaloriesPD.Text = $"Calories per day {calories_w:0.00}!!";

                        if (result > 0 && result < 18)
                        {
                            slika.Source = ImageSource.FromFile("zene1.png");
                            Message.Text = "Underweight!";
                        }
                        else if (result >= 18 && result < 24)
                        {
                            slika.Source = ImageSource.FromFile("zene2.png");
                            Message.Text = "Normal!";
                        }
                        else if (result >= 24 && result < 29)
                        {
                            slika.Source = ImageSource.FromFile("zene3.png");
                            Message.Text = "Overweight!";
                        }
                        else if (result >= 29 && result < 34)
                        {
                            slika.Source = ImageSource.FromFile("zene4.png");
                            Message.Text = "Obese!";
                        }
                        else if (result >= 34)
                        {
                            slika.Source = ImageSource.FromFile("zene5.png");
                            Message.Text = "Extremly Obese!";
                        }


                    }
                }
            }
        }
    }
}