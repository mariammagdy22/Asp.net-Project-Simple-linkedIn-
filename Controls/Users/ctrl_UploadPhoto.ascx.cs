using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using LinkedIN.BLLayer;
using System.Web.Security;

namespace LinkedIN.Controls.Users
{
    public partial class ctrl_UploadPhoto : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lbl_Message.Visible = false;

            }
        }

        protected void btn_Upload_Click(object sender, EventArgs e)
        {



            HttpPostedFile PostedFile = FileUpload_image.PostedFile;
            string fileName = Path.GetFileName(PostedFile.FileName);
            string fileExtension = Path.GetExtension(fileName);
            int fileSize = PostedFile.ContentLength;

            if (fileExtension.ToLower() == ".jpg" || fileExtension.ToLower() == ".bmp" || fileExtension.ToLower() == ".gif" || fileExtension.ToLower() == ".png")
            {
                Stream stream = PostedFile.InputStream;
                BinaryReader binaryReader = new BinaryReader(stream);
                byte[] bytes = binaryReader.ReadBytes((int)stream.Length);

                MembershipUser CurrentUser = Membership.GetUser();

                Guid UserId = (Guid)CurrentUser.ProviderUserKey;


                int newPicId = PictureBLL.AddandGetId(fileName, fileSize, bytes, UserId);                           
               
                lbl_Message.Visible = true;
                lbl_Message.Text = "upload Successful";
                lbl_Message.ForeColor = System.Drawing.Color.Green;

                byte[] imagebytes = (byte[])PictureBLL.GetImageOnlyById(newPicId);
                string strBase64 = Convert.ToBase64String(imagebytes);
                img_preview.ImageUrl = "data:Image/png;base64," + strBase64;

                if (Request.QueryString["Case"] == "AddProfilePhoto")
                {
                    UserBLL.UpdateUserProfilePic(UserId, newPicId);
                    Response.Redirect($"~/Pages/User/MyProfile.aspx");

                }
                


            }
            else
            {
                lbl_Message.Visible = true;
                lbl_Message.Text = "Only images (.jpg ,.png ,.bmp ,.gif) Can be Uploaded";
                lbl_Message.ForeColor = System.Drawing.Color.Red;
            }

        }
    }
}