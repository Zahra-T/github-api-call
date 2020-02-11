using System.IO;
using System.Net;
using System;

namespace ApiCall
{
    public class GithubApiCall
    {
            public string GetRepos(string username){
            HttpWebRequest request = WebRequest.Create("https://api.github.com/users/"+username+"/repos?per_page=100") as HttpWebRequest;
            request.UserAgent = "ApiCall";
            try{
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    string content= reader.ReadToEnd();
                    return content;
                }
            }catch(WebException ex){
                    using (var stream = ex.Response.GetResponseStream())
                    using (var reader = new StreamReader(stream))
                    {
                        return reader.ReadToEnd();
                    }
            }catch(Exception ex){
                return "unknown error has occurred/n"+ex;

            }
        }
    }
}