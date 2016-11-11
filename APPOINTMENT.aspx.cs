using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class APPOINTMENT : System.Web.UI.Page
{
    Class1 c = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void submit_Click(object sender, EventArgs e)
    {
        string query="insert into registration values('"+id.Text+"','"+name.Text+"','"+fname.Text+"','"+Address.Text+"','"+Mobile.Text+"','"+Email.Text+"','"+reason.Text+"')";
        c.ins_up_del(query);

    }
}