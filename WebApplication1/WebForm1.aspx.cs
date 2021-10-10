using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void Button1_Click(object sender, EventArgs e)
        {
            //Class1 obj = new Class1();
            //await obj.DoAsync();
            //var st= DoAsyncForUI().Result;
            var st = await DoAsyncForUI().ConfigureAwait(true);
            //var st = await obj.DoAsync();
            Button1.Text = st;
        }

        public async Task<String> DoAsyncForUI()
        {
            await Task.Delay(1000).ConfigureAwait(false);
            return "abcdUI";
        }


    }
}