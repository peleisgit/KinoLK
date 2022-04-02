using KinoLK.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinoLK.Employee
{
    public partial class Dashboard : Form
    {
        #region variables private  
        private string selectedMovie ="";
        private string selectedHours ="";
        private int numberTicket = 0;
        private int numberFood = 0;
        private int numberDrink = 0;       
        private decimal priceTicket;
        private decimal priceFood;
        private decimal priceDrink;
        private decimal TotalPrice;      
        private double discount = 0;

        #endregion
        // static powoduje że jest takie samo dla każdego obiektu
        private static decimal income = 0;
        private static int ticketsSold = 0;
        private static int numberTransaction = 0;
        private static int numberPopcorns = 0;
        private static int numberDrinks = 0;
        public int id_user;

        public decimal Income { get => income; set => income = value; }
        public int TicketsSold { get => ticketsSold; set => ticketsSold = value; }
        public int NumberTransaction { get => numberTransaction; set => numberTransaction = value; }
        public int NumberPopcorns { get => numberPopcorns; set => numberPopcorns = value; }
        public int NumberDrinks { get => numberDrinks; set => numberDrinks = value; }

        public Dashboard(int id)
        {
            InitializeComponent();
            id_user = id;
          
        }

        #region COMMON PROPS BUTTON
        private void showResult()
        {
            if (LabelLine.Visible == false)
            {
                LabelLine.Visible = true;
            }
            if(LabelTotal.Visible == false)
            {
                LabelTotal.Visible = true;
            }
            if (LabelTotalPrice.Visible == false)
            {
                LabelTotalPrice.Visible = true;
            }
        }

        private void SetTotalPrice()
        {

            TotalPrice = (priceTicket + priceFood + priceDrink) * (1 - (decimal)discount);
            LabelTotalPrice.Text = TotalPrice.ToString() + " zł";
        }
        #endregion
        #region BTN TICKET
        private void SetTextAboutTicket()
        {
            LabelMultiplerTicket.Text = string.Format("x{0}", numberTicket.ToString());
            priceTicket = numberTicket * 30;
            LabelPriceTicket.Text = priceTicket.ToString() + " zł";
            NumericUpDownTicket.Value = 0;

            if (numberTicket >= 2)
            {
                LabelFreePopcorn.Visible = true;
            }
            else
            {
                LabelFreePopcorn.Visible = false;
            }

            if (numberTicket >= 6)
            {
                LabelDiscount.Visible = true;
                LabelDiscountPrice.Visible = true;
                LabelDiscountPrice.Text = "20%";
                discount = 0.2;
            }
            else
            {
                LabelDiscount.Visible = false;
                LabelDiscountPrice.Visible = false;
                discount = 0;
            }
            if(numberTicket == 0)
            {
                LabelTicket.Visible = false;
                LabelMultiplerTicket.Visible = false;
                LabelPriceTicket.Visible = false;
            }
            else
            {
                LabelTicket.Visible = true;
                LabelMultiplerTicket.Visible = true;
                LabelPriceTicket.Visible = true;
            }
        }

        private void BtnSaleTicket_Click(object sender, EventArgs e)
        {
            LabelTicket.Visible = true;
            LabelMultiplerTicket.Visible = true;
            LabelPriceTicket.Visible = true;
           
            showResult();
            if (numberTicket >= 0)
            {
                numberTicket += Convert.ToInt32(NumericUpDownTicket.Value);
                ticketsSold += Convert.ToInt32(NumericUpDownTicket.Value);
            }
            SetTextAboutTicket();
            SetTotalPrice();
        }


        private void BtnRemoveTicket_Click(object sender, EventArgs e)
        {
            if (numberTicket > 0)
            {
                if (NumericUpDownTicket.Value <= numberTicket)
                {
                    numberTicket -= Convert.ToInt32(NumericUpDownTicket.Value);
                    ticketsSold -= Convert.ToInt32(NumericUpDownTicket.Value);
                }
                else
                {
                    MessageBox.Show("Nie możesz usunąć więcej biletów niż masz w koszyku");
                }

            }
            else
            {
                MessageBox.Show("Najpierw musisz coś dodać");
            }
            SetTextAboutTicket();
            SetTotalPrice();
        }
        #endregion
        #region BTN FOOD

        private void SetTextAboutFood()
        {
            LabelMultiplerFood.Text = string.Format("x{0}", numberFood.ToString());
            priceFood = numberFood * 10;
            LabelPriceFood.Text = priceFood.ToString() + " zł";
            NumericUpDownFood.Value = 0;
            if(numberFood == 0)
            {
                LabelMultiplerFood.Visible = false;
                LabelFood.Visible = false;
                LabelPriceFood.Visible = false;
            }
            else
            {
                LabelFood.Visible = true;
                LabelMultiplerFood.Visible = true;
                LabelPriceFood.Visible = true;
            }
        }

        private void BtnSaleFood_Click(object sender, EventArgs e)
        {           
            showResult();           
            if (numberFood >= 0)
            {
                numberFood += Convert.ToInt32(NumericUpDownFood.Value);
                numberPopcorns += Convert.ToInt32(NumericUpDownFood.Value);

            }
            SetTextAboutFood();
            SetTotalPrice();
        }

        private void BtnRemoveFood_Click(object sender, EventArgs e)
        {
            if (numberFood > 0)
            {
                if (NumericUpDownFood.Value <= numberFood)
                {
                    numberFood -= Convert.ToInt32(NumericUpDownFood.Value);
                    numberPopcorns -= Convert.ToInt32(NumericUpDownFood.Value);
                }
                else
                {
                    MessageBox.Show("Nie możesz usunąć więcej popcornów niż masz w koszyku");
                }
            }
            else
            {
                MessageBox.Show("Najpierw musisz coś dodać");
            }
            SetTextAboutFood();
            SetTotalPrice();
        }
        #endregion
        #region BTN DRINK

        private void SetTextAboutDrink()
        {
            LabelMultiplerDrink.Text = string.Format("x{0}", numberDrink.ToString());
            priceDrink = numberDrink * 7;
            LabelPriceDrink.Text = priceDrink.ToString() + " zł";
            NumericUpDownDrink.Value = 0;
            if(numberDrink == 0)
            {
                LabelDrink.Visible = false;
                LabelMultiplerDrink.Visible = false;
                LabelPriceDrink.Visible = false;
            }
            else
            {
                LabelDrink.Visible = true;
                LabelMultiplerDrink.Visible = true;
                LabelPriceDrink.Visible = true;
            }
        }

        private void BtnSaleDrink_Click(object sender, EventArgs e)
        {   
            showResult();            
            if(numberDrink >= 0)
            {
                numberDrink += Convert.ToInt32(NumericUpDownDrink.Value);
                numberDrinks += Convert.ToInt32(NumericUpDownDrink.Value);
            }
            SetTextAboutDrink();
            SetTotalPrice();
        }

        private void BtnRemoveDrink_Click(object sender, EventArgs e)
        {
            if (numberDrink > 0)
            {    
                if (NumericUpDownDrink.Value <= numberDrink)
                {
                    numberDrink -= Convert.ToInt32(NumericUpDownDrink.Value);                   
                    numberDrinks -= Convert.ToInt32(NumericUpDownDrink.Value);                   
                }
                else
                {
                    MessageBox.Show("Nie możesz usunąć więcej napojów niż masz w koszyku");
                }
            }
            else
            {
                MessageBox.Show("Najpierw musisz coś dodać");
            }
            SetTextAboutDrink();
            SetTotalPrice();
        }
        #endregion
        #region BTN RECIPT


        private void ClearAll()
        {
            TotalPrice = 0;
            numberTicket = 0;
            numberFood = 0;
            numberDrink = 0;
            priceTicket = 0;
            priceFood = 0;
            priceDrink = 0;
            TotalPrice = 0;
            discount = 0;
            //
            LabelTicket.Visible = false;
            LabelFood.Visible = false;
            LabelDrink.Visible = false;
            LabelMultiplerTicket.Visible = false;
            LabelMultiplerFood.Visible = false;
            LabelMultiplerDrink.Visible = false;
            LabelPriceTicket.Visible = false;
            LabelPriceFood.Visible = false;
            LabelPriceDrink.Visible = false;
            LabelDiscount.Visible = false;
            LabelDiscountPrice.Visible = false;
            LabelTotal.Visible = false;
            LabelTotalPrice.Visible = false;
            LabelFreePopcorn.Visible = false;
            LabelLine.Visible = false;
        }

        private void BtnRecipt_Click(object sender, EventArgs e)
        {
            if (TotalPrice > 0)
            {
                Income += TotalPrice;
                NumberTransaction++;
                Income incomeObject = new Income(Income, TicketsSold, NumberTransaction, NumberPopcorns, NumberDrinks);  
                TotalPrice = 0;
            }
            else
            {
                MessageBox.Show("Koszyk jest pusty");
            }
            ClearAll();
        }
        #endregion;
        #region BTN CLEAR
 
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        #endregion
    }
}
