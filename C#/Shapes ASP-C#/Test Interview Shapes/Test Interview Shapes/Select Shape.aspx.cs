using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test_Interview_Shapes
{
    public partial class Select_Shape : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string drawShape = "";
            int height;
            
            if (DropDownList1.SelectedItem.Text == "Triangle")
            {
                drawShape = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;             x                 \n" + "<br>" +
                            "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                        xxx                \n" + "<br>" +
                            "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                                         xxxxxx               \n" + "<br>" +
                            "&nbsp;&nbsp;&nbsp;                                                         xxxxxxxxxx             \n" + "<br>" +
                            "                                                                          xxxxxxxxxxxx            \n" ;
            }
            if (DropDownList1.SelectedItem.Text == "Square")
            {

                drawShape =              "&nbsp;     x x  x xx x   " + "<br>" +
                                         "           x_________x   " + "<br>" +
                                         "           x_________x   " + "<br>" +
                                         "           x_________x   " + "<br>" +
                                         "&nbsp;     x x  x xx x   ";

            }
            if (DropDownList1.SelectedItem.Text == "Rectangle")
            {

                drawShape =            "&nbsp; x x x x x x x x   " + "<br>" +
                                       "       x_____________x   " + "<br>" +
                                       "       x_____________x   " + "<br>" +
                                       "       x_____________x   " + "<br>" +
                                       "&nbsp; x x x x x x x x   ";

            }
            if (DropDownList1.SelectedItem.Text == "Diamond")
            {

                drawShape =   "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    x      " + "<br>" +
                              "                 &nbsp;&nbsp;   x___x    "+ "<br>" +
                              "                              x______x  " + "<br>" +
                                                    " &nbsp;   x___x    " + "<br>" +
                               "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   x      ";

            }
            //Get the data from the previous form, frmPersonnel.aspx
     
            // If the data is correct it will successfully save, if not it will not save
            height = Convert.ToInt32(TextBox1.Text);
            Label1.Font.Size = height;
            clsDataLayer.SavePersonnel(Server.MapPath("Shapedatabase.accdb"), DropDownList1.SelectedItem.Text, height);
         

            Label1.Text =  drawShape;
            GridView1.DataBind();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}