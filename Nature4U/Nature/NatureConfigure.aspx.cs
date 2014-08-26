using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Nature4U.NatureServiceRef;

namespace Nature4U.Nature
{
    public partial class NatureConfigure : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadBodyPartsData();
            }
        }

        private void LoadBodyPartsData()
        {
            NatureServiceClient nsvc = new NatureServiceClient();
            List<BodyParts> lstBodyP  =nsvc.GetBodyParts();
            ddlParentParts.DataTextField = "Name";
            ddlParentParts.DataValueField = "BodyPartID";
            ddlParentParts.DataSource = lstBodyP;
            ddlParentParts.DataBind();
        }

        protected void bntClean_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtDescription.Text = string.Empty;
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            int BodyPartID=0;
            BodyParts objParts = new BodyParts();
            objParts.Name = txtName.Text;
            objParts.Description = txtDescription.Text;
            objParts.BodyParentID = Convert.ToInt32(ddlParentParts.SelectedItem.Value);
            NatureServiceClient nsvc = new NatureServiceClient();
            BodyPartID =nsvc.InsertBodyParts(objParts);
            if (BodyPartID > -1)
            {
                ddlParentParts.Items.Add(new ListItem(txtName.Text,BodyPartID.ToString()));
                lblMessages.Text = "¡Registro Insertado de manera exitosa!";
                System.Threading.Thread.Sleep(500);
                lblMessages.Text = "";
            }
        }
    }
}