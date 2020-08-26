using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblResult.Text = "";
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        int qtyA = Convert.ToInt32(txtQtyA.Text.ToString());
        int qtyB = Convert.ToInt32(txtQtyB.Text.ToString());
        int qtyC = Convert.ToInt32(txtQtyC.Text.ToString());
        int qtyD = Convert.ToInt32(txtQtyD.Text.ToString());

        if (chkA.Checked && chkB.Checked && chkC.Checked && chkD.Checked)
        {
            if (qtyA == 1 && qtyB == 1 && qtyC == 1 && qtyD == 1)
            {
                callAPromotion(1, qtyA, qtyB, qtyC, qtyD);
            }

            if (qtyA >= 3 && qtyB == 1)
            {
                callAPromotion(2, qtyA, qtyB, qtyC, qtyD);
            }

            if (qtyB >= 2 && qtyA == 1)
            {
                callAPromotion(3, qtyA, qtyB, qtyC, qtyD);
            }

            if (qtyA >= 3 && qtyB >= 2) 
            {
                callAPromotion(4, qtyA, qtyB, qtyC, qtyD);
            }

            if (qtyA >= 3 && qtyB >= 2 && qtyC == 1 && qtyD == 1)
            {
                callAPromotion(5, qtyA, qtyB, qtyC, qtyD);
            }

            if (qtyA >= 3 && qtyB >= 2 && qtyC >= 1 && qtyD == 0)
            {
                callAPromotion(6, qtyA, qtyB, qtyC, qtyD);
            }

            if (qtyA >= 3 && qtyB >= 2 && qtyD >= 1 && qtyC == 0)
            {
                callAPromotion(7, qtyA, qtyB, qtyC, qtyD);
            }

            if (qtyA >= 3 && qtyB >= 2 && qtyC > 1 && qtyD == 1)
            {
                callAPromotion(8, qtyA, qtyB, qtyC, qtyD);
            }

            if (qtyA >= 3 && qtyB >= 2 && qtyD > 1 && qtyC == 1)
            {
                callAPromotion(9, qtyA, qtyB, qtyC, qtyD);
            }
        }

        if (chkC.Checked && chkD.Checked && !chkA.Checked && !chkB.Checked)
        {
            if (qtyC == 1 && qtyD == 1)
            {
                callBPromotion(1, qtyA, qtyB, qtyC, qtyD);
            }
            else if (qtyC >= 1 && qtyD == 0)
            {
                callBPromotion(2, qtyA, qtyB, qtyC, qtyD);
            }
            else if (qtyD >= 1 && qtyC == 0)
            {
                callBPromotion(3, qtyA, qtyB, qtyC, qtyD);
            }

            if (qtyC > 1 && qtyD == 1)
            {
                callCPromotion(1, qtyA, qtyB, qtyC, qtyD);
            }
            else if (qtyD > 1 && qtyC == 1)
            {
                callCPromotion(2, qtyA, qtyB, qtyC, qtyD);
            }
        }
    }

    protected void callAPromotion(int option, int qtyA, int qtyB, int qtyC, int qtyD)
    {
        if (option == 1)
        {
            lblResult.Text = Convert.ToString(
                                 qtyA * 50 +
                                 qtyB * 30 +
                                 qtyC * 20 +
                                 qtyD * 15);
        }
        else if (option == 2)
        {
            lblResult.Text = Convert.ToString(
                      (qtyA/3) * 130 + (qtyA%3) * 50 +
                             qtyB * 30 +
                             qtyC * 20 +
                             qtyD * 15);
        }
        else if (option == 3)
        {
            lblResult.Text = Convert.ToString(
                               qtyA * 50 +
                               (qtyB/2) * 45 + (qtyB%2) * 30 +
                                qtyC * 20 +
                                qtyD * 15);
        }
        else if (option == 4)
        {
            lblResult.Text = Convert.ToString(
                               (qtyA / 3) * 130 + (qtyA % 3) * 50 +
                               (qtyB / 2) * 45 + (qtyB % 2) * 30 +
                                qtyC * 20 +
                                qtyD * 15);
        }
        else if (option == 5)
        {
            lblResult.Text = Convert.ToString(
                             (qtyA / 3) * 130 + (qtyA % 3) * 50 +
                             (qtyB / 2) * 45 + (qtyB % 2) * 30 +
                             30);
        }
        else if (option == 6)
        {
            lblResult.Text = Convert.ToString(
                             (qtyA / 3) * 130 + (qtyA % 3) * 50 +
                             (qtyB / 2) * 45 + (qtyB % 2) * 30 +
                             qtyC * 20);
        }
        else if (option == 7)
        {
            lblResult.Text = Convert.ToString(
                             (qtyA / 3) * 130 + (qtyA % 3) * 50 +
                             (qtyB / 2) * 45 + (qtyB % 2) * 30 +
                             qtyD * 15);
        }
        else if (option == 8)
        {
            lblResult.Text = Convert.ToString(
                             (qtyA / 3) * 130 + (qtyA % 3) * 50 +
                             (qtyB / 2) * 45 + (qtyB % 2) * 30 +
                              (((qtyC - qtyD) * 20) + (qtyD * 30)));
        }
        else if (option == 9)
        {
            lblResult.Text = Convert.ToString(
                             (qtyA / 3) * 130 + (qtyA % 3) * 50 +
                             (qtyB / 2) * 45 + (qtyB % 2) * 30 +
                             (((qtyC - qtyD) * 15) + (qtyD * 30)));
        }
        else
        {
            lblResult.Text = "";
        }
    }

    protected void callBPromotion(int option, int qtyA, int qtyB, int qtyC, int qtyD)
    {
        if (option == 1)
        {
            lblResult.Text = Convert.ToString(
                             qtyA * 50 +
                             qtyB * 30 +                              
                             30);
        }
        else if (option == 2)
        {
            lblResult.Text = Convert.ToString(
                             qtyA * 50 +
                             qtyB * 30 +
                             qtyC * 20);
        }
        else if (option == 3)
        {
            lblResult.Text = Convert.ToString(
                             qtyA * 50 +
                             qtyB * 30 +
                             qtyD * 15);
        }
    }

    protected void callCPromotion(int option, int qtyA, int qtyB, int qtyC, int qtyD)
    {
        if (option == 1)
        {           
            lblResult.Text = Convert.ToString(
                             qtyA * 50 +
                             qtyB * 30 +
                             (((qtyC - qtyD) * 20) + (qtyD * 30)));
        }
        else if (option == 2)
        {
            lblResult.Text = Convert.ToString(
                             qtyA * 50 +
                             qtyB * 30 +
                             (((qtyC - qtyD) * 15) + (qtyD * 30)));
        }
    }
}