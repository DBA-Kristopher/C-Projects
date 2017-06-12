using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Final
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
            // Draws shape
            string drawShape = "";
            // Shape height
            int height;
            // user shape label input
            string shapecharacters = "default";
            shapecharacters = TextBox2.Text;
            int labelLenght = shapecharacters.Length;

            string shapespace;
            string initials;

            //Check for space in user input for label
            switch (labelLenght)
            {
                case 1:
                    shapespace = "&nbsp;&nbsp;";
                    initials = shapecharacters + shapespace;
                    break;
                case 2:
                    shapespace = "&nbsp;";
                    initials = shapecharacters + shapespace;
                    break;

                default:
                    initials = shapecharacters.Substring(0, 3);
                    break;
            }


            if (DropDownList1.SelectedItem.Text == "Triangle")
            {
                drawShape = "<br> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;X                \n" + "<br>" +
                            "&nbsp;&nbsp;&nbsp;&nbsp;XXX               \n" + "<br>" +
                            "&nbsp;&nbsp;&nbsp;XXXXX                                                    \n" + "<br>" +
                            "&nbsp;&nbsp;XX" + initials + "XX         \n" + "<br>" +
                            "&nbsp;XXXXXXXXX       \n";


            }


            if (DropDownList1.SelectedItem.Text == "Square")
            {

                drawShape = "<br> XXXXXXXXX  " + "<br>" +
                                         "  XXXXXXXXX   " + "<br>" +
                                         " XX&nbsp;" + initials + "&nbsp;XX  " + "<br>" +
                                         " XXXXXXXXX " + "<br>" +
                                         "  XXXXXXXXX  ";

            }
            if (DropDownList1.SelectedItem.Text == "Rectangle")
            {

                drawShape = "<br> XXXXXXXXXXXXXXXXXXX     " + "<br>" +
                                       "     XXXXXXXXXXXXXXXXXXX      " + "<br>" +
                                       "      XXXXXXX&nbsp;" + initials + "&nbsp;XXXXXXX      " + "<br>" +
                                        "      XXXXXXXXXXXXXXXXXXX      " + "<br>" +
                                       "      XXXXXXXXXXXXXXXXXXX      ";

            }
            if (DropDownList1.SelectedItem.Text == "Diamond")
            {

                drawShape = "<br> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    X   " + "<br>" +
                              "  &nbsp;&nbsp;&nbsp;&nbsp;  XXX" + "<br>" +
                              "  &nbsp;&nbsp;&nbsp;  X" + initials + "X" + "<br>" +
                              "&nbsp;&nbsp;&nbsp;&nbsp;  XXX " + "<br>" +
                               "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; X     ";

            }
            //Get the data from the previous form, frmPersonnel.aspx

            // If the data is correct it will successfully save, if not it will not save
            height = Convert.ToInt32(TextBox1.Text);

            Label1.Font.Size = height + 10;
            Label3.Text = Label3.Text + "<br>" + DropDownList1.SelectedItem.Text + " " + height;
            //clsDataLayer.SavePersonnel("~/App_Data/Shapedatabase.accdb", DropDownList1.SelectedItem.Text, height);
            // TextBox3.Text = "~/App_Data/Shapedatabase.accdb" + DropDownList1.SelectedItem.Text + height.ToString();
            //Label1.Font = new Font("Arial");
            Label1.Text = drawShape;
            //GridView1.DataBind();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}