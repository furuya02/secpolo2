using System;
using System.Collections.Generic;
using System.Web.UI;
using Facebook.Web;

namespace WebRole1{
    public partial class _Default : Page{
        protected void Page_Load(object sender, EventArgs e){

            var auth = new CanvasAuthorizer { Permissions = new[] { "user_about_me","read_requests" } };

            if (auth.Authorize()){
            
                var fb = new FacebookWebClient();

                dynamic me = fb.Get("me");
                //友達リクエストの一覧取得
                var fql = String.Format("SELECT uid_from FROM friend_request WHERE uid_to={0}", me.id);
                var result = fb.Query(fql);
                //リクエストした人のidのリストを作成
                var list = new List<string>();
                foreach (var o in result){
                    list.Add(o.uid_from);
                }
                Title = result.ToString();
                
                //ログオンしているFacebookユーザーに関する情報を取得
                //dynamic myInfo = fb.Get("me");
                //Title = myInfo.name;

            }
        }

        protected void Button3_Click(object sender, EventArgs e) {
            Response.Redirect("NextPage.aspx");
        }   

    }
}
