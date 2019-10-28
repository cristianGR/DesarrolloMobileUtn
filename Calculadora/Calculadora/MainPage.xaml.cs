using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Content = GridComponent();
        }

        public Layout GridComponent()
        {
            Calculadora calculadora = new Calculadora();
            string ingreso = "";
            int flag = 0;
            var grilla = new Grid();
            var pila = new StackLayout();
            pila.BackgroundColor = Color.DarkGray;
            pila.Padding = 5;
            pila.Margin = 0;
            

            //definición de filas
            grilla.RowDefinitions.Add(new RowDefinition { Height = new GridLength(130)});
            grilla.RowDefinitions.Add(new RowDefinition { Height = new GridLength(130)});
            grilla.RowDefinitions.Add(new RowDefinition { Height = new GridLength(130)});
            grilla.RowDefinitions.Add(new RowDefinition { Height = new GridLength(130)});
            grilla.RowDefinitions.Add(new RowDefinition { Height = new GridLength(130)});

            //definición de columnas
            grilla.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(83)});
            grilla.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(83)});
            grilla.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(83)});
            grilla.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(83)});

            var display = new Label
            {
                Text = "",
                BackgroundColor = Color.White,
                HorizontalTextAlignment = TextAlignment.End,
                VerticalTextAlignment = TextAlignment.End,
                TextColor = Color.Black,
                FontSize = 60
            };

            pila.Children.Add(display); ;

            var btnCalculator = new String[] {"9","8","7","+","6","5","4","-","3","2","1","*","c","0",",","/"};
            var row = 0;
            var column = 0;
            for (int i = 0; i < btnCalculator.Length; i++)
            {
                var btn = new Button { Text = btnCalculator[i] };
                btn.Clicked += OnBtnPressed;
                btn.CornerRadius = 15;
                btn.FontSize = 40;
                if(btnCalculator[i].ToString() == "c")
                    btn.BackgroundColor = Color.Orange;
                else
                    btn.BackgroundColor = Color.Gray;
                btn.FontFamily = "Bold";
                grilla.Children.Add(btn,row,column);
                if (row!=3)
                    row++; 
                else
                {
                    row = 0;
                    column++;
                }
            }


            void OnBtnPressed(object sender, EventArgs e)
            {
                var btn = sender as Button;
                
                if (btn.Text!="c" && btn.Text!="+" && btn.Text != "-" && btn.Text != "*" && btn.Text != "/" && btn.Text != "=")
                {
                    if (ingreso != "")
                    {
                        ingreso += btn.Text;
                        display.Text = ingreso;
                    }

                    if (ingreso == "")
                    {
                        ingreso = btn.Text;
                        display.Text += btn.Text;
                    }
                    
                }

                if (btn.Text == "+" || btn.Text == "-" || btn.Text == "*" || btn.Text == "/"  && flag != 1)
                {
                    display.Text += btn.Text;
                    calculadora.IngresarNumero(float.Parse(ingreso));
                    ingreso = "";
                    flag = 1;

                    if (btn.Text == "+")
                    {
                        calculadora.Mas();
                    }

                    if (btn.Text == "-")
                    {
                        calculadora.Menos();
                    }

                    if (btn.Text == "*")
                    {
                        calculadora.Multiplicacion();
                    }

                    if (btn.Text == "/")
                    {
                        calculadora.Division();
                    }
                }

                if (flag == 1 && ingreso != "")
                {
                    calculadora.IngresarNumero(float.Parse(ingreso));
                    ingreso = calculadora.GetResultado().ToString();
                    calculadora.Preset(calculadora.GetResultado());
                    display.Text = ingreso;
                    flag = 0;
                    
                }

                if (btn.Text == "c")
                {
                    ingreso = "";
                    display.Text = "";
                    calculadora.Reset();
                    flag = 0;
                    
                }

            }

            pila.Children.Add(grilla);

            return pila;
        }

        
    }


    public class Calculadora
    {
        float mantisa = 0;
        string operacion = "";

        public void IngresarNumero(float numero)
        {
            if (operacion == "")
                mantisa = numero;

            if (operacion == "+")
                mantisa += numero;

            if (operacion == "-")
                mantisa -= numero;

            if (operacion == "*")
                mantisa *= numero;

            if (operacion == "/" && numero != 0)
            {
                mantisa /= numero;
            }
            else if (operacion == "/" && numero == 0)
            {
                Console.WriteLine("ingrese un nro distinto de cero como divisor");
            }
        }
        public void Mas()
        {
            operacion = "+";
        }
        public void Menos()
        {
            operacion = "-";
        }
        public void Multiplicacion()
        {
            operacion = "*";
        }
        public void Division()
        {
            operacion = "/";
        }

        public float GetResultado()
        {
            return mantisa;
        }

        public void Reset()
        {
            mantisa = 0;
            operacion = "";
        }

        public void Preset(float nro)
        {
            mantisa = nro;
            operacion = "";
        }
    }

}
