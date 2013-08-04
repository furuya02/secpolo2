using System;
using System.Web.UI;
using Facebook.Web;

namespace WebRole1{
    public partial class _Default : Page{
        protected void Page_Load(object sender, EventArgs e){

            var auth = new CanvasAuthorizer { Permissions = new[] { "user_about_me","read_requests" } };

            if (auth.Authorize()){
            
                var fb = new FacebookWebClient();

                //var d = fb.Query("SELECT '' FROM friend_request WHERE uid_to=me() AND unread=1");
                dynamic me = fb.Get("me");
                var fql = String.Format("SELECT uid_from FROM friend_request WHERE uid_to={0}", me.id);
                //var fql = String.Format("SELECT uid,name, sex, pic,username FROM user WHERE username =\"furuya02\"");
                var d = fb.Query(fql);

                Title = d.ToString();
                //ログオンしているFacebookユーザーに関する情報を取得
                //dynamic myInfo = fb.Get("me");
                //Title = myInfo.name;

            }
        }
    }
}
